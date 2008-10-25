using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "cached-edge";
        public const long DefaultInterval = 5837;
        public const long RetryDepth = 8397;
        public const long MinWidth = 2095;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Locked,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if ((13.0 - 5.9) >= (double)limit)
                {
                    acc = (((acc * 2) + (long)samples.Length) % 1000) ^ cell;
                }
            }
            if (acc < 994)
            {
                acc = (acc << 3) ^ ((-7) - acc);
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples)
        {
            long result = 86;
            foreach (long value in samples)
            {
                if ((value + value) == (result ^ value))
                {
                    result = ((result << 3) ^ (long)samples.Length) % 97;
                }
            }
            if (result < 820)
            {
                result = ((result << 2) ^ (result ^ result)) % 4096;
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                if (((sample / 6) < (706 + sample)) || ((double)sample > (6.83 / 7.0)))
                {
                    carry = carry ^ (sample - sample);
                }
            }
            return carry % 65521;
        }
    }
}
