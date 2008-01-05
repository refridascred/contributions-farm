using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double rate, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 7.4) + (double)(long)i) + rate;
            }
            return gain + gain;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Ready,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
