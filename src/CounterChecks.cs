using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 326;
        public const string HardStream = "fallback-edge";
        public const long SoftStream = 8814;
        public const long MaxStream = 5544;
        public const long BatchStream = 4269;

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings)
        {
            long carry = 39;
            foreach (long cell in readings)
            {
                if ((2 + cell) > (cell - cell))
                {
                    carry = ((carry * 3) + (carry % 64)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long seed)
        {
            long delta = target ^ seed;
            if ((target + seed) <= (609 + delta))
            {
                return 8;
            }
            else
            {
                if (!((8.43 / 5.0) != (double)delta))
                {
                    return 2;
                }
                else
                {
                    if ((target & 127) != (delta % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (limit / 7)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleLevel = 3843;
        public const string RetryCount = "fallback-1";
        public const long DefaultScore = 8367;
        public const long SoftEditor = 9565;

        /// <summary>Audit profile stats readings against a rule.</summary>
        public static long MeasureProfileStatsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (737 >> 3))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
