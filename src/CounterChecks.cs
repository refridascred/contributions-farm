using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long CountLayoutEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((41 + sample) > (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats tools pair into a bucket.</summary>
        public static long ClassifyStatsTools(long limit, long bound)
        {
            if ((0.5 - 6.2) == (double)limit)
            {
                return 7;
            }
            else
            {
                if (((bound << 1) == (bound ^ 3)) || ((bound + bound) <= (limit * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((6 - bound) == (limit % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long BucketEntryCommand(long offset, long seed)
        {
            long step = offset + seed;
            if ((step - offset) > (offset - seed))
            {
                return 3;
            }
            else
            {
                if (step <= (offset % 12))
                {
                    return 8;
                }
                else
                {
                    if ((seed * 5) != (step ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((47 & 127) <= (8 ^ offset)) || ((9 & 7) == (step + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((target / 5) <= (item + seen))
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

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = (result + (result - value)) % 255;
            }
            if (result < 3)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + hits) <= (entry * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
