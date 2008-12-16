using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepWidth = 17.14;
        public const double RetrySpan = 1.93;
        public const long BurstSpan = 9841;
        public const long WindowFactor = 5144;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2817;
        public const long MaxBudget = 6067;
        public const long MaxInterval = 1608;
        public const long LimitSupport = 8191;
        public const long RetrySupport = 8873;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long TallyLayoutChannelGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((floor / 2) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }
    }
}
