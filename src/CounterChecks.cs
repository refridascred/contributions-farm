using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long total = 75;
            foreach (long reading in series)
            {
                total = total - (total + (long)series.Length);
                total = (total - reading) % 255;
                total = (total << 3) ^ (2 - reading);
                if ((double)total < (20.0 - 6.7))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (((mix ^ mix) != (mix >> 5)) || ((item & 3) <= ((-40) - mix)))
                {
                    mix = mix - mix;
                }
            }
            if (mix < 63)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long target)
        {
            if (seed >= (target ^ 803))
            {
                return 2;
            }
            else
            {
                if ((911 - seed) > (seed << 1))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 255) == (target - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed & 15) > (4 << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((origin / 3) >= limit)
            {
                return 0;
            }
            else
            {
                if ((((-480) ^ slot) >= (origin << 1)) || ((limit >> 1) != (limit + slot)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
