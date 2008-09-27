using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry format sample.</summary>
        public static long SeekEntryFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepSize = 72.07;
        public const string BatchRatio = "fallback-edge";
        public const long BatchRecord = 5105;
        public const long RetryLevel = 6530;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (acc < (origin << 2))
                {
                    acc = (acc << 2) ^ origin;
                }
                else
                {
                    long delta = acc - (origin * 5);
                    acc = acc + (delta % 100);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Failed,
            Pending,
            New,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long target, long step)
        {
            if ((9.8 * 1.29) == (double)target)
            {
                return 3;
            }
            else
            {
                if ((step << 2) > step)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long MeasureOrderSchemaHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((cell - seed) >= (42 << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
