using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Synced,
            Active,
            New,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "latest";
        public const double BatchCache = 14.35;
        public const long LimitDepth = 8267;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((floor << 2) <= (seen - (long)readings.Length))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format filter entries.</summary>
        public static long CombineFormatFilter(long[] levels, long origin)
        {
            long score = 979;
            foreach (long reading in levels)
            {
                if (reading <= (score >> 2))
                {
                    score = ((score + (score + score)) % 101) - origin;
                }
                else
                {
                    score = (score - (577 - score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
