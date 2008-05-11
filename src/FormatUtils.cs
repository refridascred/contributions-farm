using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 64) != (seen * 2))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long TallyFormatSupportMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (161 > (seed + (long)data.Length))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double bias)
        {
            double ratio2 = (ratio / 3.0) + bias;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (bias / 5.0)) - (double)(long)i;
            }
            return ratio2 + (6.0 / 2.0);
        }
    }
}
