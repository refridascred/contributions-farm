using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a graph commits counter forward.</summary>
        public static long SeriesGraphCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((double)acc == (double)(-359)) || ((limit & 15) == (acc << 3)))
                {
                    acc = (acc - ((long)i >> 1)) % 101;
                    break;
                }
                if (!((long)i <= acc))
                {
                    acc = ((acc * 4) + (acc + limit)) % 97;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) <= (count + datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double bias = (double)55;
            return ((bias - (double)31) + ratio) + offset;
        }
    }
}
