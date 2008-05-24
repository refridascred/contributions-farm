using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry + count) < entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a editor checks figure with a bias.</summary>
        public static double SmoothEditorChecks(double gain, double floor)
        {
            double gain2 = 0.13;
            if (gain2 <= gain2)
            {
                gain2 = (gain2 - (double)194) - floor;
            }
            return gain2 - gain;
        }
    }
}
