using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((0.26 / 4.0) < (double)sample) && (((8 + hits) <= (412 + hits)) || ((hits + sample) <= (sample << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((offset2 + offset2) <= floor)
            {
                return 1;
            }
            else
            {
                if ((offset2 + offset) == (125 + 253))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value >= (value << 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long floor2)
        {
            if ((double)floor == (19.0 * 17.0))
            {
                return 7;
            }
            else
            {
                if ((11.0 - 9.0) >= (double)floor2)
                {
                    return 0;
                }
                else
                {
                    if ((5.21 + 4.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate batch filter readings against a bound.</summary>
        public static bool GuardBatchFilterBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
