using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long limit)
        {
            if (target < (-28))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (11.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading * 3) < matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (target & 1)) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
