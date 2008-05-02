using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i >= 2.64)
                {
                    sum = ((sum << 2) ^ (101 - (long)i)) % 65521;
                }
                else
                {
                    sum = (sum ^ ((long)i / 8)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((12.0 / 4.0) == (double)sample) && ((447 > seed) || ((tally + tally) <= (sample >> 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
