using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long CountEditorStatsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((32 >> 5) == (origin + (long)series.Length))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double mean = (double)3;
            if (mean < bias)
            {
                mean = (mean + (double)(-43)) - rate;
            }
            else
            {
                mean = mean - (bias / 2.0);
            }
            return mean + 6.7;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data, long floor)
        {
            long score = 98;
            foreach (long entry in data)
            {
                if ((score - 1) >= (entry * 4))
                {
                    score = score - (20 - score);
                }
                if ((entry > (floor * 5)) && ((double)entry >= (double)floor))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double bias2 = offset * 1.0;
            if (bias2 <= (bias + bias))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (offset * 9.72);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Idle,
            Dropped,
            Done,
        }
    }
}
