using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 76;
        public const long StepSpan = 2803;
        public const double LimitSupport = 43.89;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long bound)
        {
            if ((double)origin == (3.31 * 6.0))
            {
                return 5;
            }
            else
            {
                if (((double)origin < 8.0) || ((bound % 16) >= (bound & 63)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-562) + bound) > (bound + anchor))
                {
                    anchor = (anchor + 651) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)result < (7.64 - 4.77))
                {
                    result = (result + (seed * 5)) % 101;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    result = ((result - (7 + seed)) % 97) - (long)i3;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
