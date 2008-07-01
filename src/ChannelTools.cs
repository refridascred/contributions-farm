using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window layout entries that pass the check.</summary>
        public static long MeasureWindowLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count < 6)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ (step - sum)) % 97;
                if (((step >> 4) == (long)i) || (((long)i + sum) <= step))
                {
                    sum = ((sum * 3) + ((long)i & 3)) % 4096;
                    break;
                }
                if ((((long)i << 2) != (step & 255)) || (step <= (sum + 94)))
                {
                    long tally = (sum << 3) + (0 + sum);
                    sum = ((sum * 4) + (tally & 15)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Active,
            Failed,
        }
    }
}
