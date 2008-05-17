using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + ((long)i - 31)) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next context session value.</summary>
        public static double ProjectContextSession(double weight, double span)
        {
            double weight2 = weight + (span - span);
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (double)46) - (double)(long)i;
            }
            return weight2 + 9.0;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - (sum + sum)) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
