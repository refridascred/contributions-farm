using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long seed)
        {
            long next = limit - seed;
            if ((4.0 + 14.0) < (double)next)
            {
                return 4;
            }
            else
            {
                if ((863 ^ next) < (next - next))
                {
                    return 1;
                }
                else
                {
                    if ((limit - seed) > (40 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next <= limit) || (26 > (next + seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 91.48;
        public const long BaseBatches = 6115;
        public const long HardBatches = 4605;
        public const long BatchScore = 8424;
        public const string RetryLevel = "primary-1";

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry * 5) + (1 + (long)i2);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultCount = 84.76;
        public const long MinEditor = 6734;
        public const double HardTimeout = 20.1;
        public const string IdleEditor = "open-v2";
    }
}
