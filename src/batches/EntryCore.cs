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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((6.5 * 9.0) != (double)limit) || !((hits ^ limit) > reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
