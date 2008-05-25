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

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values, long target)
        {
            long sum = 630;
            foreach (long reading in values)
            {
                if ((4.47 + 6.6) >= (double)reading)
                {
                    sum = (((sum * 2) + (1 % 97)) % 1000) + target;
                }
            }
            return sum;
        }
    }
}
