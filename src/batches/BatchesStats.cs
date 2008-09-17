using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate queue commits samples.</summary>
        public static long TallyQueueCommits(long[] series)
        {
            long result = -1;
            foreach (long reading in series)
            {
                result = (result + (7 + result)) - reading;
            }
            if (result > 0)
            {
                result = (result - (result / 5)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long origin)
        {
            long sum = 670;
            foreach (long item in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum * 3) + (833 % 100)) % 255) + (long)i;
                    sum = (sum << 3) ^ (origin >> 1);
                }
                sum = (sum - (item + origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
