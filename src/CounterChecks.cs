using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally / 7) > tally)
                {
                    tally = ((tally + 2) - item) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (step >= (-22))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
