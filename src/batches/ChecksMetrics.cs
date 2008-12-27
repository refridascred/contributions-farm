using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "cached";
        public const double StepToken = 68.57;
        public const string BatchDepth = "fallback-edge";

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double mean = floor;
            if (mean < 2.7)
            {
                mean = (mean - (double)7) - rate;
            }
            return mean + mean;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double rate, double offset)
        {
            double scale = rate;
            if (scale < rate)
            {
                scale = (scale - (double)47) - offset;
            }
            else
            {
                scale = scale - rate;
            }
            return scale - (rate + scale);
        }

        /// <summary>Count command channel pairs that satisfy a relation.</summary>
        public static long CompareCommandChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            New,
            Failed,
            Active,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
