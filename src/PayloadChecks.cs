using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Done,
            New,
            Locked,
        }

        /// <summary>Measure how many entry buffer samples are out of range.</summary>
        public static long TallyEntryBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell * 3) < cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long step)
        {
            long prev = target - step;
            if ((double)target != (7.8 + 3.21))
            {
                return 7;
            }
            else
            {
                if ((double)109 >= (double)prev)
                {
                    return 4;
                }
                else
                {
                    if (target < (prev - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.37 / 3.0) >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (seed > (seed + seed))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Failed,
            Done,
            New,
            Pending,
        }
    }
}
