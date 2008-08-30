using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long MeasureCounterGithubfarmHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + entry) < hits)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + (6 ^ limit)) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (6.6 > (double)hits)
                {
                    hits = ((hits + 1) + item) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "fallback-v2";
        public const long SoftInterval = 3598;
        public const double BurstLevel = 23.18;
        public const long MinRatio = 9424;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Pending,
            Done,
        }
    }
}
