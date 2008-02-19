using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double offset)
        {
            double gain = offset;
            if (gain < (offset - 8.9))
            {
                gain = gain - 2.26;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 2927;
        public const double HardMetric = 58.24;
        public const long MinSize = 3520;
        public const double WindowMetric = 62.6;

        /// <summary>Match up commits farm samples.</summary>
        public static long MatchCommitsFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
