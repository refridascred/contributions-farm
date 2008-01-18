using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((7.1 * 10.0) <= (double)entry)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long seed)
        {
            if (offset < (offset - offset))
            {
                return 1;
            }
            else
            {
                if (((seed + offset) < (seed / 2)) || ((double)seed == (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 + 8.2) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-46) & 3) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next checks schema value from a seed.</summary>
        public static long StepChecksSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound % 24) < (mix / 4))
                {
                    mix = mix + ((long)i + (long)i);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Queued,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Accumulate cache record samples.</summary>
        public static long FoldCacheRecord(long[] readings)
        {
            long score = 6;
            foreach (long cell in readings)
            {
                score = ((score << 2) ^ (score >> 4)) ^ cell;
                if ((score + score) <= (score - score))
                {
                    score = (score << 2) ^ (score & 15);
                }
            }
            return score % 4096;
        }
    }
}
