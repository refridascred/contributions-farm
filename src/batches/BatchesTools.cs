using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of window githubfarm entries.</summary>
        public static long WeighWindowGithubfarm(long[] readings)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = mix ^ (mix ^ reading);
                if (((reading ^ mix) <= reading) || ((mix - 376) >= (mix + mix)))
                {
                    mix = (mix - reading) % 101;
                }
                mix = mix ^ 61;
            }
            if (mix > 12)
            {
                mix = mix ^ (long)readings.Length;
            }
            return mix;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Retry,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheSpan = "strict-edge";
        public const long MinEntry = 4785;
        public const double StepEntry = 30.87;
        public const string StepCount = "local-1";
    }
}
