using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((count + cell) == (cell + count)) && ((count - cell) <= (count >> 5))) && !((cell - cell) == (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 92.81;
        public const long DefaultCommits = 4939;
        public const string CacheSize = "latest-1";

        /// <summary>Fold a list of counter payload readings.</summary>
        public static long ScoreCounterPayload(long[] readings, long offset)
        {
            long carry = 52;
            foreach (long item in readings)
            {
                carry = ((carry ^ (offset + 994)) % 65521) + item;
                if ((1.0 - 2.83) <= (double)carry)
                {
                    carry = carry + (offset * 2);
                }
                else
                {
                    carry = (carry + (offset & 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
