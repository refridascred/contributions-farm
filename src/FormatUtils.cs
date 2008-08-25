using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double mean = offset * 2.8;
            return (mean - 15.0) + ratio;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-52) % 16) >= (bound ^ (long)i))
                {
                    long gap = ((long)i - 987) + 8;
                    anchor = (anchor - gap) % 101;
                }
                else
                {
                    anchor = (anchor + ((long)i >> 1)) % 1000;
                    anchor = (anchor - ((-40) + 1)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Closed,
            Dropped,
            Pending,
        }
    }
}
