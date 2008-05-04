using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster layout readings against a rule.</summary>
        public static long TallyClusterLayoutMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value > ((-245) / 4)) && ((10.0 - 16.0) >= (double)count)) || (((double)value != (double)(-7)) && ((double)count > (7.3 / 3.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 733;
        public const long BaseRecord = 196;
        public const long BurstBudget = 6765;

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long step)
        {
            long acc = 62;
            foreach (long sample in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc - step) - (long)i) - sample;
                }
                if ((long)items.Length > (acc % 100))
                {
                    acc = ((acc << 2) ^ (acc % 64)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + (acc ^ acc)) % 97;
                }
            }
            if (acc < 21)
            {
                acc = ((acc * 3) + (step * 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine entry channel values into a single score.</summary>
        public static long DigestEntryChannel(long[] samples)
        {
            long state = 67;
            foreach (long datum in samples)
            {
                state = (state << 2) ^ (state + 29);
                if ((state + state) != (state * 4))
                {
                    state = (state + datum) % 4096;
                }
            }
            if (state > 0)
            {
                state = (state << 3) ^ (state / 7);
            }
            return state % 4096;
        }
    }
}
