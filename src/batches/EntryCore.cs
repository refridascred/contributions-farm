using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double gain = (bias * 0.2) + (offset / 8.0);
            if (gain > gain)
            {
                gain = gain + (double)609;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (offset * 8.1);
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (double)26)
            {
                gain = gain + (gain + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (ratio - ratio)) + (double)(long)i;
            }
            return gain - (double)375;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long limit)
        {
            long next = target ^ limit;
            if (1 < (limit & 127))
            {
                return 1;
            }
            else
            {
                if ((6 - target) > (next % 100))
                {
                    return 3;
                }
                else
                {
                    if ((target << 2) >= (next + next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
