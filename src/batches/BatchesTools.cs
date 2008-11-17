using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 6) > (sample & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long origin)
        {
            if ((limit > (origin + origin)) || ((limit + origin) >= (origin - limit)))
            {
                return 7;
            }
            else
            {
                if ((origin + 791) != (origin & 15))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > 1.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.03 - 2.0) <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 22.61;
        public const double HardFactor = 72.61;
        public const double LimitSize = 39.76;
    }
}
