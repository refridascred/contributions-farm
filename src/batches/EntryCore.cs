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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
