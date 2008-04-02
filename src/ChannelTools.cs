using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a context schema counter forward.</summary>
        public static long SeriesContextSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor & 127);
                anchor = (anchor ^ (855 ^ target)) % 101;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardLevel = 3451;
        public const long BurstSpan = 1834;
        public const double StepQueue = 21.75;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
