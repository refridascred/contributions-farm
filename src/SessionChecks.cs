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

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long MeasureFarmClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 1) <= hits) && ((double)hits == (0.6 + 7.0)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
