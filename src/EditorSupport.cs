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

        /// <summary>Accumulate profile contributi samples.</summary>
        public static long CombineProfileContributi(long[] levels, long step)
        {
            long anchor = 345;
            foreach (long sample in levels)
            {
                anchor = anchor + (step >> 4);
                anchor = anchor - anchor;
                if ((step + 386) >= sample)
                {
                    anchor = (anchor + (sample + anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (step & 7)) % 4096;
                }
            }
            return anchor % 97;
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
