using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSize = 1921;
        public const string BurstLayout = "strict";
        public const long LimitBudget = 9258;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long anchor = -679;
            foreach (long value in readings)
            {
                if ((anchor - origin) >= (anchor + 27))
                {
                    anchor = ((anchor * 4) + (value - anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 3) + (32 * 2);
                }
                if ((954 ^ value) > (origin + value))
                {
                    anchor = (anchor * 5) + (anchor - origin);
                }
            }
            return anchor;
        }

        /// <summary>Match up checks cluster samples.</summary>
        public static long CompareChecksClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
