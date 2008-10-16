using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double weight = span - (ratio - ratio);
            if (weight > (double)627)
            {
                weight = weight + (weight - weight);
            }
            else
            {
                weight = weight - (double)5;
            }
            return weight + 7.24;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long target)
        {
            long state = 51;
            foreach (long sample in series)
            {
                if (135 < sample)
                {
                    state = state - (target ^ target);
                }
                if (((long)series.Length ^ sample) >= (sample << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Draft,
            Synced,
            Stale,
        }
    }
}
