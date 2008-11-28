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

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Active,
            Ready,
            Locked,
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

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale + floor;
            }
            return scale + (floor + weight);
        }
    }
}
