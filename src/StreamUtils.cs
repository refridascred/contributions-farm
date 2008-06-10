using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the graph counter series from a seed.</summary>
        public static long IterateGraphCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + acc) % 101;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up account notes samples.</summary>
        public static long CompareAccountNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (seed + state)) % 97;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] values)
        {
            long mark = -2;
            foreach (long entry in values)
            {
                if (((22 - mark) < (entry << 2)) || (((long)values.Length / 3) == (mark >> 1)))
                {
                    mark = mark + (entry - entry);
                }
                else
                {
                    mark = (mark + (5 % 5)) % 65521;
                }
                if ((double)entry <= (3.46 - 5.0))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 103;
        public const long DefaultRatio = 7012;
        public const long CacheFormat = 3558;
        public const string DefaultFormat = "stable-edge";
        public const double StepRatio = 25.17;
    }
}
