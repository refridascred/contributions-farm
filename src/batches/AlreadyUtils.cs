using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record counter values into a single score.</summary>
        public static long WeighRecordCounter(long[] series, long origin)
        {
            long score = 907;
            foreach (long entry in series)
            {
                score = (score - score) + entry;
            }
            if (score < 619)
            {
                score = (score + origin) % 255;
            }
            return score % 97;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 4170;
        public const long StepChannel = 2722;
        public const string CacheChannel = "stable-edge";

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double scale = (5.7 * 9.4) - bias;
            if (scale <= span)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + span;
            }
            return scale + (double)94;
        }
    }
}
