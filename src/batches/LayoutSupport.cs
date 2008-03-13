using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Done,
            Active,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9160;
        public const string BaseInterval = "standard";
        public const long MaxMetric = 5862;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 8594;
        public const string MinNotes = "fallback";
        public const long CacheNotes = 547;
        public const long BurstNotes = 6594;
        public const string SoftNotes = "latest";

        /// <summary>Accumulate graph cache samples.</summary>
        public static long DigestGraphCache(long[] readings, long origin)
        {
            long mix = 11;
            foreach (long datum in readings)
            {
                if ((datum << 2) >= (datum % 64))
                {
                    mix = ((mix * 3) + (origin * 4)) % 1000;
                }
                if (!((244 - origin) < ((long)readings.Length - datum)))
                {
                    mix = (mix + (mix ^ datum)) % 1000;
                }
            }
            if (mix > 827)
            {
                mix = (mix - (mix + mix)) % 101;
            }
            return mix;
        }
    }
}
