using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "legacy-edge";
        public const string DefaultCount = "strict-v2";
        public const long IdleSize = 6596;
        public const double BurstProfile = 56.86;
        public const long MaxProfile = 3962;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Paused,
            New,
            Done,
            Active,
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long StepCounterAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long seed)
        {
            long total = 787;
            foreach (long reading in readings)
            {
                if ((reading / 9) <= total)
                {
                    total = (total - total) + seed;
                }
            }
            return total;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long delta = seed - limit;
            if ((8.51 * 12.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if (seed > delta)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - item) > limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
