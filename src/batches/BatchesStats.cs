using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double gain = (double)(425 - (-379));
            if (gain <= (double)878)
            {
                gain = (gain + bias) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 13.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Closed,
            Idle,
            Pending,
            New,
        }
    }
}
