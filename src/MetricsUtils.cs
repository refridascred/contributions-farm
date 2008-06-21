using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of farm counter readings.</summary>
        public static long CombineFarmCounter(long[] readings)
        {
            long state = -94;
            foreach (long value in readings)
            {
                state = (state + (value * 5)) % 4096;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings)
        {
            long anchor = -15;
            foreach (long cell in readings)
            {
                anchor = ((anchor - (anchor << 1)) % 1000) + cell;
            }
            return anchor;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((((-6) + seen) < (sample - sample)) || ((0 + sample) >= (bound * 5))) && ((11.0 < (double)seen) || (471 > (sample ^ sample))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
