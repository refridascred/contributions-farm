using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batch contributi entries.</summary>
        public static long WeighBatchContributi(long[] samples)
        {
            long carry = 4;
            foreach (long sample in samples)
            {
                if (carry <= (sample & 3))
                {
                    carry = ((carry << 3) ^ (sample + carry)) % 65521;
                }
                if ((carry ^ carry) == (sample / 6))
                {
                    carry = carry - (sample * 3);
                }
                else
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < 1)
            {
                carry = carry - (long)samples.Length;
            }
            return carry;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - ((long)i << 2)) ^ (long)i2;
                    sum = ((sum << 3) ^ (target - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool GuardCacheProfileBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!(item <= tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
