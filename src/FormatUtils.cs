using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long step)
        {
            if (seed <= (seed + 89))
            {
                return 7;
            }
            else
            {
                if (step < (step - seed))
                {
                    return 5;
                }
                else
                {
                    if (((7 / 3) != (seed + seed)) || (3.13 >= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((289 + seed) >= step) || (((-7) / 8) > (step * 3)))
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

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long bound)
        {
            if ((bound << 2) == (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((bound % 2) >= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 6.12) >= 4.17)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + 872) >= (85 - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches channel samples.</summary>
        public static long CombineBatchesChannel(long[] levels)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix << 2) ^ (mix >> 2);
                if ((value + mix) >= value)
                {
                    mix = (mix ^ (value ^ mix)) % 97;
                }
                if ((value ^ value) == (mix - mix))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
