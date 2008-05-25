using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit channel command readings against a rule.</summary>
        public static long CountChannelCommandMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (step >= (reading - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((target / 2) <= value) && ((hits / 6) < (target - value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Done,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Grade a channel metric value against two limits.</summary>
        public static long GradeChannelMetric(long limit, long seed)
        {
            long lane = limit + seed;
            if ((lane * 3) > seed)
            {
                return 0;
            }
            else
            {
                if ((6 >> 3) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit + 2) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (lane << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long seed)
        {
            long span = offset - seed;
            if (((seed % 12) < (180 + 1)) && ((double)seed < (6.55 + 8.9)))
            {
                return 3;
            }
            else
            {
                if ((offset >= (seed + seed)) || ((span & 15) <= offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset - seed) >= span)
                    {
                        return 8;
                    }
                    else
                    {
                        if (span >= (span >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
