using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long seed)
        {
            long delta = floor ^ seed;
            if ((double)floor > 2.93)
            {
                return 6;
            }
            else
            {
                if ((floor - delta) >= (seed % 16))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next record buffer value from a seed.</summary>
        public static long StepRecordBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ (floor - result)) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinWidth = "strict-1";
        public const string IdleRatio = "strict";
        public const long DefaultEditor = 3865;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)origin < (20.0 + 1.0))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound + acc) <= (bound ^ (long)i))
                {
                    acc = (acc - bound) % 101;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc * 5) + ((long)i2 ^ acc);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
