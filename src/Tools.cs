using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate filter account samples.</summary>
        public static long TallyFilterAccount(long[] levels, long limit)
        {
            long score = -11;
            foreach (long datum in levels)
            {
                if ((limit ^ limit) < 499)
                {
                    score = (score ^ score) ^ datum;
                }
                if ((8.95 + 2.9) <= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count payload counter pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a counter token reading by value.</summary>
        public static long FindCounterTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double bias2 = (double)(67 - 67);
            if (bias2 < 8.67)
            {
                bias2 = ((bias2 - (double)915) - rate) - bias;
            }
            return bias2 + (double)651;
        }
    }
}
