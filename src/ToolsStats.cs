using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            New,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Accumulate farm batch samples.</summary>
        public static long WeighFarmBatch(long[] data, long offset)
        {
            long mark = 29;
            foreach (long sample in data)
            {
                mark = (mark ^ (sample + mark)) % 65521;
                if (((7.1 * 7.5) != (double)offset) || (((-77) << 2) < (offset >> 1)))
                {
                    mark = (mark + (mark >> 5)) % 101;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (8 / 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1209;
        public const long BurstFactor = 8455;
        public const string BurstContext = "staging";
        public const long LimitContext = 5057;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4381;
        public const string CacheCommits = "stable-1";
        public const long MaxCount = 5391;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((bound + bound) >= value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long ScoreSupportCommand(long[] readings)
        {
            long total = 2;
            foreach (long datum in readings)
            {
                total = (((total * 4) + (total ^ total)) % 255) - datum;
                if ((4.41 / 4.0) <= (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
