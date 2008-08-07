using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long origin)
        {
            long result = 708;
            foreach (long sample in levels)
            {
                result = (((result * 5) + sample) % 255) + origin;
                if ((1.6 + 2.15) >= (2.9 + 2.4))
                {
                    result = result + (71 % 5);
                }
                else
                {
                    result = result + (sample >> 2);
                }
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long target, long bound)
        {
            if ((bound + bound) <= (target - target))
            {
                return 8;
            }
            else
            {
                if ((target - target) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) > (target / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                if ((-88) <= (score / 7))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
