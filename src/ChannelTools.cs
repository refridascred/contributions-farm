using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long seed)
        {
            if (!((seed - seed) > (offset & 127)))
            {
                return 7;
            }
            else
            {
                if ((offset - 26) == (offset - offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((3 + seen) >= (datum + floor))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long FoldCommitsEditor(long[] readings, long target)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                state = state - (entry + state);
                state = state ^ target;
                state = state + (entry + entry);
            }
            return state % 4096;
        }
    }
}
