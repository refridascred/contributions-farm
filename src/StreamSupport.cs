using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (7.2 - 9.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit account layout readings against a rule.</summary>
        public static long AuditAccountLayoutMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 4) < (seed + tally))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a checks metric pair into a bucket.</summary>
        public static long ClassifyChecksMetric(long seed, long offset)
        {
            if ((offset - offset) < (offset - 7))
            {
                return 8;
            }
            else
            {
                if (((seed - offset) == (offset + offset)) && (seed > (771 - seed)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (16.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((7.0 - 3.7) > (double)offset) && (seed < (offset / 9)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
