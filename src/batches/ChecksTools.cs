using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster stats series from a seed.</summary>
        public static long RollClusterStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (26 * 4)) % 4096;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
