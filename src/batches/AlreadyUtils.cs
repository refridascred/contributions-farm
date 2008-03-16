using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long limit, long origin)
        {
            long gap = limit ^ origin;
            if ((5.07 - 8.0) > (double)limit)
            {
                return 3;
            }
            else
            {
                if (((8.78 / 9.0) != (double)origin) && ((double)gap != (1.52 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
