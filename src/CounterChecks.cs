using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if ((double)datum == (4.0 * 2.5))
                {
                    total = (total + (datum & 7)) % 255;
                }
            }
            return total % 1000;
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long step)
        {
            long sum = 393;
            foreach (long entry in data)
            {
                sum = ((sum ^ (step * 4)) % 101) - entry;
            }
            return sum;
        }

        /// <summary>Audit cluster channel readings against a rule.</summary>
        public static long TallyClusterChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell + 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
