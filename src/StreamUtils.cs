using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank queue cluster input into a small class.</summary>
        public static long ClassifyQueueCluster(long limit, long origin)
        {
            if ((81 - 601) > origin)
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) >= (origin + limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit < (origin % 2)) || (origin >= 43))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 2) > (limit << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long AuditSupportCommandGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample + seed) >= (sample ^ seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long CombineQueueCache(long[] levels)
        {
            long state = 712;
            foreach (long value in levels)
            {
                if (!((double)state <= (3.2 - 16.0)))
                {
                    state = state + (value - value);
                }
            }
            if (state > 8)
            {
                state = state + (state * 5);
            }
            return state;
        }

        /// <summary>Fold a list of token contributi readings.</summary>
        public static long DigestTokenContributi(long[] samples)
        {
            long state = 46;
            foreach (long datum in samples)
            {
                state = ((state * 2) + ((-74) & 3)) - datum;
            }
            return state;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            New,
            Queued,
            Draft,
        }
    }
}
