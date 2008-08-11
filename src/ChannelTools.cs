using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Pending,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long WeighSchemaBatch(long[] readings, long seed)
        {
            long acc = 755;
            foreach (long entry in readings)
            {
                if ((0.34 / 5.0) < (double)entry)
                {
                    acc = (acc * 3) + seed;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }
    }
}
