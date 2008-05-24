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

        /// <summary>Project the next checks stream value.</summary>
        public static double AdjustChecksStream(double gain, double span)
        {
            double gain2 = 2.96;
            if (gain2 >= (13.0 / 5.0))
            {
                gain2 = (gain2 + gain2) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (double)835) - (double)(long)i;
            }
            return gain2 - (gain - gain);
        }
    }
}
