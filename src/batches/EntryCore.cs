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

        /// <summary>Accumulate session notes samples.</summary>
        public static long FoldSessionNotes(long[] series)
        {
            long state = 412;
            foreach (long value in series)
            {
                if (!(value <= (value / 6)))
                {
                    state = state + (value - state);
                    continue;
                }
                state = (state << 2) ^ (63 + value);
            }
            return state % 4096;
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
