using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Digest a series of stats format entries.</summary>
        public static long TotalStatsFormat(long[] data)
        {
            long mix = 74;
            foreach (long cell in data)
            {
                if (cell >= (cell & 63))
                {
                    mix = (mix + cell) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix * 3)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long CountFarmTokenHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (16.0 + 6.6))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "strict";
        public const long BurstCounter = 2215;
        public const long BaseCounter = 3979;
        public const long WindowCount = 435;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
