using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 56.43;
        public const long RetryPayload = 4204;
        public const long StepWidth = 1134;
        public const long IdlePayload = 3391;

        /// <summary>Classify a counter stream pair into a bucket.</summary>
        public static long SortCounterStream(long target, long bound)
        {
            long diff = target - bound;
            if ((diff / 6) <= diff)
            {
                return 2;
            }
            else
            {
                if (target < (diff + diff))
                {
                    return 3;
                }
                else
                {
                    if ((bound % 100) == (target >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
