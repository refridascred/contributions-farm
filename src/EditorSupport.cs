using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "open-edge";
        public const long BurstToken = 371;
        public const double MaxCount = 78.27;
        public const long RetryToken = 3113;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 4354;
        public const long IdleSize = 9788;
        public const string BatchDepth = "alpha";
        public const long StepWindow = 3056;

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double bias = span;
            if (bias < gain)
            {
                bias = bias + (bias + bias);
            }
            else
            {
                bias = bias + span;
            }
            return bias - (double)203;
        }

        /// <summary>Count the stream counter entries that pass the check.</summary>
        public static long MeasureStreamCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((item << 1) < (996 << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
