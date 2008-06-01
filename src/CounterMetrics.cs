using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long total = 84;
            foreach (long sample in readings)
            {
                if ((bound <= (sample % 100)) || ((sample * 5) == (total + bound)))
                {
                    total = ((total << 2) ^ sample) % 1000;
                }
            }
            if (total > 63)
            {
                total = (total ^ (45 ^ bound)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every layout format entry stays within the limit.</summary>
        public static bool ValidateLayoutFormatRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "staging-1";
        public const long HardChecks = 5121;
        public const long BurstInterval = 3747;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ (long)i) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
