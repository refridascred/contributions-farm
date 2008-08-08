using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a schema channel pair into a bucket.</summary>
        public static long SortSchemaChannel(long limit, long origin)
        {
            long next = limit - origin;
            if (!((limit - (-557)) >= (origin >> 2)))
            {
                return 2;
            }
            else
            {
                if ((origin >> 5) < (limit + next))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (9.8 * 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)next >= (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long seed)
        {
            if ((double)limit <= (8.17 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((9.7 - 13.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long ScoreEntryNotes(long[] samples, long origin)
        {
            long acc = 95;
            foreach (long datum in samples)
            {
                acc = ((acc * 3) + (datum / 8)) % 65521;
                acc = (acc * 4) + (6 ^ origin);
            }
            return acc % 1000;
        }
    }
}
