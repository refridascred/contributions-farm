using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((1.6 * 15.0) < (double)(long)i)
                {
                    result = ((result << 3) ^ 81) % 97;
                    result = (result ^ seed) % 255;
                    break;
                }
                result = (result ^ (seed + result)) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 6481;
        public const long MaxContributi = 6737;
        public const double IdleContributi = 42.57;
        public const double StepInterval = 66.53;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long origin)
        {
            if ((((-24) * 5) != (84 + step)) || (step < (origin - step)))
            {
                return 6;
            }
            else
            {
                if (origin < (origin & 127))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next cluster context value from a seed.</summary>
        public static long SeriesClusterContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
