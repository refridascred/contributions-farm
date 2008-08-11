using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double bias = span;
            if (bias < (double)97)
            {
                bias = (bias + bias) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 9.92) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long offset)
        {
            if ((double)offset <= (6.8 - 7.78))
            {
                return 5;
            }
            else
            {
                if ((offset % 16) < (target + offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset + 989) != (offset % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
