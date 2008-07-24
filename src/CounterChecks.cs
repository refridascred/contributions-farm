using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if (!(entry > (entry << 3)))
                {
                    sum = (sum + (543 / 3)) % 97;
                }
                if ((double)entry <= (16.0 + 4.0))
                {
                    sum = sum - (sum - entry);
                }
                else
                {
                    sum = sum ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 5575;
        public const long CacheInterval = 8313;
        public const long IdleTimeout = 3243;
        public const long StepProfile = 5849;
        public const long IdleProfile = 7142;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long CountEntryBatchesGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + 3) <= count)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long MeasureNotesChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (8.59 / 2.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
