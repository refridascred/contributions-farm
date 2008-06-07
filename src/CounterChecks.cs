using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum / 6) <= datum)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (86 >> 4)) % 97;
                sum = (sum - 394) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "legacy-1";
        public const long DefaultSpan = 1088;
        public const long WindowEditor = 8664;
        public const double StepEditor = 72.8;

        /// <summary>Count the buffer batch entries that pass the check.</summary>
        public static long TallyBufferBatchGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)45 == (double)sample)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
