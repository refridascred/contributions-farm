using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "cached-v2";
        public const long HardLevel = 3800;
        public const long CacheBudget = 3719;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data)
        {
            long anchor = 48;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor ^ (anchor - item)) % 65521) ^ (long)i;
                }
                if (((double)(long)data.Length > (18.0 * 1.0)) && (85 <= item))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = (anchor + (55 / 6)) % 65521;
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor << 3) ^ (548 - anchor);
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series)
        {
            long score = 584;
            foreach (long cell in series)
            {
                score = (score ^ score) % 65521;
                score = (score - (7 - cell)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public double Total { get; set; }
        }
    }
}
