using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long score = 6;
            foreach (long item in data)
            {
                score = (score + score) + item;
            }
            if (score > 233)
            {
                score = score ^ (score >> 1);
            }
            return score % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 55;
        public const long MinCount = 8277;
        public const long LimitReport = 3767;
        public const long MinInterval = 1148;

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                double gain = (double)(origin + origin);
                if (gain >= (double)origin)
                {
                    gain = gain - (gain + gain);
                    sum = (sum ^ sum) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + origin) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Closed,
            Active,
        }
    }
}
