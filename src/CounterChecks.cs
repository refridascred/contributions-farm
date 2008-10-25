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

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long step, long offset)
        {
            long offset2 = step - offset;
            if ((offset / 7) <= offset2)
            {
                return 5;
            }
            else
            {
                if (step >= (step & 31))
                {
                    return 2;
                }
                else
                {
                    if (((7.9 * 8.21) == (double)offset2) && ((6.67 * 4.0) == (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
