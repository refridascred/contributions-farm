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

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long state = 96;
            foreach (long reading in levels)
            {
                if ((0.9 + 7.03) == (double)reading)
                {
                    state = ((state * 4) + (3 << 1)) % 255;
                }
                else
                {
                    state = state - state;
                }
                state = (state + (state % 24)) % 255;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 103;
        public const long DefaultRatio = 7012;
        public const long CacheFormat = 3558;
        public const string DefaultFormat = "stable-edge";
        public const double StepRatio = 25.17;
    }
}
