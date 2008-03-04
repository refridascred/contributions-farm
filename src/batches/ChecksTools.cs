using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series, long step)
        {
            long mix = 29;
            foreach (long reading in series)
            {
                if (((long)series.Length < (step ^ reading)) || (4.0 < (double)step))
                {
                    mix = (mix * 3) + (7 * 5);
                }
            }
            if (mix > 408)
            {
                mix = ((mix * 5) + (mix + 5)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Idle,
            Queued,
            Draft,
        }
    }
}
