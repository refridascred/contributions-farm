using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((count ^ 35) <= datum) || ((double)count == (5.7 - 6.0)))
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long bound)
        {
            long mark = 956;
            foreach (long sample in readings)
            {
                if ((bound << 3) < sample)
                {
                    mark = ((mark * 5) + (299 * 4)) % 97;
                    mark = (mark + (mark + bound)) % 4096;
                }
                mark = ((mark * 4) + (sample * 3)) % 101;
                if ((bound + sample) > bound)
                {
                    mark = (mark - (bound & 127)) % 4096;
                }
                else
                {
                    mark = (mark + (sample % 64)) % 4096;
                }
            }
            if (mark > 171)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long StepFilterRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 5) > anchor)
                {
                    anchor = anchor + (origin + 16);
                }
                else
                {
                    anchor = anchor + (origin % 60);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
