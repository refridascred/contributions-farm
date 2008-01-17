using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstLevel = 81.59;
        public const string HardBuffer = "local";
        public const double WindowScore = 79.48;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long mark = 938;
            foreach (long cell in readings)
            {
                if ((cell >> 2) != (63 + mark))
                {
                    mark = ((mark << 3) ^ (target - mark)) % 255;
                }
            }
            if (mark > 64)
            {
                mark = (mark * 4) + (target * 3);
            }
            return mark;
        }

        /// <summary>Rank order buffer input into a small class.</summary>
        public static long BucketOrderBuffer(long limit, long step)
        {
            if ((2.72 / 4.0) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if (((double)limit > 11.0) && ((5.35 * 20.0) == (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) == (step / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
