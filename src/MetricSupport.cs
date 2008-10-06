using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a channel already reading.</summary>
        public static double ScaleChannelAlready(double gain, double bias)
        {
            double gain2 = (double)((-33) << 2);
            if (gain2 >= bias)
            {
                gain2 = gain2 + (gain2 * 4.0);
            }
            return gain2 - gain;
        }

        /// <summary>Compare every pair of stream editor readings.</summary>
        public static long MatchStreamEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up session notes samples.</summary>
        public static long OverlapSessionNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
