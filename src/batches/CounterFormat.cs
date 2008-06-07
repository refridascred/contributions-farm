using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long sum = 2;
            foreach (long item in data)
            {
                sum = (sum + (sum + item)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings, long origin)
        {
            long acc = -8;
            foreach (long datum in readings)
            {
                if ((origin & 15) != (acc % 16))
                {
                    acc = ((acc << 2) ^ (origin << 2)) + datum;
                }
            }
            if (acc > 85)
            {
                acc = ((acc * 4) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of buffer counter readings.</summary>
        public static long OverlapBufferCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
