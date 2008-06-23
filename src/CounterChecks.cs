using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public long Token { get; set; }
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

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long limit)
        {
            if ((limit & 127) != (bound - limit))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 5;
                }
                else
                {
                    if (!(5.42 < (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound <= (1.28 - 9.7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
