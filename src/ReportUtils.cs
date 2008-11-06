using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long step)
        {
            long bound = seed ^ step;
            if ((step - 96) > step)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= (seed / 3))
                {
                    return 8;
                }
                else
                {
                    if (((double)16 < (double)step) || ((seed + seed) >= (step << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long step)
        {
            long cur = limit + step;
            if (((limit << 3) <= (cur & 63)) || (step >= (step + step)))
            {
                return 1;
            }
            else
            {
                if ((double)step == (8.68 + 0.9))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Combine already command values into a single score.</summary>
        public static long FoldAlreadyCommand(long[] samples, long offset)
        {
            long mix = 317;
            foreach (long entry in samples)
            {
                if ((double)offset > (double)710)
                {
                    mix = ((mix ^ offset) % 97) ^ entry;
                }
            }
            if (mix < 2)
            {
                mix = (mix ^ (mix + offset)) % 255;
            }
            return mix;
        }
    }
}
