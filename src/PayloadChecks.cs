using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of cache commits readings.</summary>
        public static long FoldCacheCommits(long[] data, long offset)
        {
            long total = 431;
            foreach (long item in data)
            {
                total = (((total ^ (33 - 59)) % 1000) + item) - offset;
            }
            return total % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((988 + 816) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-1";
        public const double MaxFarm = 44.94;
        public const long CacheSize = 7632;

        /// <summary>Fold a list of channel batch readings.</summary>
        public static long TallyChannelBatch(long[] readings, long step)
        {
            long result = 94;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result - (0 + (long)i)) % 1000;
                }
                if ((sample << 1) > (sample + result))
                {
                    result = result ^ (0 + step);
                }
            }
            return result;
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] readings)
        {
            long mix = 678;
            foreach (long cell in readings)
            {
                if (((8.9 - 7.59) > (double)mix) || ((4.92 * 4.45) > (double)cell))
                {
                    mix = (mix + (0 % 10)) % 65521;
                }
                mix = mix - cell;
            }
            if (mix < 62)
            {
                mix = mix - (2 * 5);
            }
            return mix;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
