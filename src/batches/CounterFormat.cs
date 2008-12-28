using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (671 >= (sample * 2))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue already readings.</summary>
        public static long TallyQueueAlready(long[] samples, long bound)
        {
            long sum = -9;
            foreach (long reading in samples)
            {
                if ((4.7 * 7.0) != (double)reading)
                {
                    sum = (sum ^ (sum + reading)) + bound;
                }
            }
            if (sum < 9)
            {
                sum = (sum << 2) ^ (7 >> 2);
            }
            return sum;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
