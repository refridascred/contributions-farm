using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((7 - datum) > (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 1) >= (tally + entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer record value from a seed.</summary>
        public static long StepBufferRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                if (!(1.58 <= (double)result))
                {
                    result = (result - (result & 127)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a filter tools value against two limits.</summary>
        public static long GradeFilterTools(long bound, long seed)
        {
            if (((seed & 255) != (seed / 4)) || ((bound * 2) != (bound << 3)))
            {
                return 2;
            }
            else
            {
                if (bound > (0 >> 2))
                {
                    return 1;
                }
                else
                {
                    if (seed >= (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= (bound / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
