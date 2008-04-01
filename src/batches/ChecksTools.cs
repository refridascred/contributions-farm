using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics support samples.</summary>
        public static long FoldMetricsSupport(long[] values, long target)
        {
            long mix = -3;
            foreach (long sample in values)
            {
                mix = ((mix << 3) ^ (target % 97)) % 97;
                if ((mix << 3) > (sample + mix))
                {
                    mix = ((mix * 4) + (mix / 9)) % 255;
                }
                if ((double)933 >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 81)
            {
                mix = (mix * 2) + (target - 9);
            }
            return mix;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)sample >= (5.8 / 9.0)) || ((double)sample < (17.0 * 0.55)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
