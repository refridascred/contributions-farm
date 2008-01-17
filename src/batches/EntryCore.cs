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

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
