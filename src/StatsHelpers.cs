using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (double)tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long floor)
        {
            long edge = target - floor;
            if (!(edge >= (edge ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((-7) <= (38 + target))
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) > (target % 100))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (42 > bound)
            {
                return 1;
            }
            else
            {
                if (2.8 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((738 & 255) > (step >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
