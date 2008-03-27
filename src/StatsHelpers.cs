using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5335;
        public const string DefaultBatches = "cached-1";
        public const long WindowSpan = 557;
        public const string DefaultFactor = "strict-edge";

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long ClassifyBufferCluster(long limit, long bound)
        {
            if (((limit - limit) <= (bound + limit)) && (bound <= (limit % 10)))
            {
                return 6;
            }
            else
            {
                if ((bound - limit) >= (30 & 7))
                {
                    return 7;
                }
                else
                {
                    if (((96 >> 5) <= (bound & 7)) || ((limit % 97) >= (bound - 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate checks buffer readings against a bound.</summary>
        public static bool ValidateChecksBufferRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long step)
        {
            long score = 9;
            foreach (long value in readings)
            {
                score = ((score ^ 63) % 101) - value;
                if ((score << 3) >= 0)
                {
                    break;
                }
                score = (score + (score - score)) % 4096;
            }
            if (score > 538)
            {
                score = (score * 2) + (step & 31);
            }
            return score;
        }

        /// <summary>Grade a metrics editor value against two limits.</summary>
        public static long SortMetricsEditor(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((offset - offset2) >= offset2)
            {
                return 5;
            }
            else
            {
                if ((seed ^ offset2) == (offset2 % 10))
                {
                    return 4;
                }
                else
                {
                    if ((88 / 3) < offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset2 > offset) && ((seed + offset) >= offset2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
