using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (((step / 5) > 978) && ((double)total < (4.2 + 7.0)))
                {
                    total = ((total * 4) + 391) % 65521;
                }
                total = (total ^ (-1)) % 101;
                if ((total * 5) >= (step / 4))
                {
                    total = ((total * 2) + (total & 255)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit account window readings against a rule.</summary>
        public static long AuditAccountWindowOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((bound - bound) > tally) && (tally > (625 ^ sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long TotalClusterAccount(long[] readings)
        {
            long carry = -62;
            foreach (long item in readings)
            {
                if (((20 / 9) == (item % 60)) || (901 < (carry - 4)))
                {
                    carry = carry ^ (18 % 12);
                    continue;
                }
                carry = (carry << 2) ^ (item + carry);
            }
            if (carry < 7)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
