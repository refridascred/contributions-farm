using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long step, long target)
        {
            long prev = step + target;
            if ((step * 2) <= target)
            {
                return 4;
            }
            else
            {
                if ((double)prev == (3.1 * 9.53))
                {
                    return 0;
                }
                else
                {
                    if (target >= (target - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a notes batches figure with a bias.</summary>
        public static double BlendNotesBatches(double ratio, double bias)
        {
            double mean = ratio - (ratio + bias);
            if (mean > bias)
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            return mean + (19.0 + 5.97);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultInterval = 23.59;
        public const long CacheSize = 797;
        public const long RetryGithubfarm = 51;
        public const long LimitWidth = 1811;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            New,
            Closed,
            Dropped,
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
