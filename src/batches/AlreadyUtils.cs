using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (((result / 9) != (result >> 5)) || (((long)i << 3) != ((long)i ^ (long)i)))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a graph metric counter forward.</summary>
        public static long SeriesGraphMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound + mix) <= mix)
                {
                    mix = mix ^ ((long)i - (long)i);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                bool stale = (target * 4) >= mark;
                if (stale)
                {
                    mark = (mark - ((-71) + target)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
