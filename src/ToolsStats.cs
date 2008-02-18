using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((5.7 / 5.0) == (double)state)
                {
                    continue;
                }
                else
                {
                    state = state - (state >> 3);
                }
                if ((state / 3) <= state)
                {
                    state = (state - bound) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((slot >= limit) && (1 > (60 + slot)))
            {
                return 8;
            }
            else
            {
                if ((floor + limit) > (limit - floor))
                {
                    return 2;
                }
                else
                {
                    if (!((limit ^ floor) >= (limit - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((98 & 63) > value)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Rank graph support input into a small class.</summary>
        public static long RankGraphSupport(long offset, long bound)
        {
            if (bound > 175)
            {
                return 7;
            }
            else
            {
                if ((bound / 8) < (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound <= (11.0 + 16.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset > 70)
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
    }
}
