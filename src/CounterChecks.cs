using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Derive the next payload githubfarm value from a seed.</summary>
        public static long SeriesPayloadGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 3) ^ seed) % 101) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool GuardReportEntryBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseTimeout = "stable-v2";
        public const double BurstCluster = 3.39;
        public const long LimitCluster = 9930;

        /// <summary>Validate farm profile readings against a bound.</summary>
        public static bool ValidateFarmProfileBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
