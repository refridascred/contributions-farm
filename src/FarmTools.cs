using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double ratio = (double)((-88) - (-7));
            if (ratio > (5.0 * 1.0))
            {
                ratio = (ratio + span) - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 3.0)) - (double)(long)i;
            }
            return ratio + (double)436;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Idle,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
