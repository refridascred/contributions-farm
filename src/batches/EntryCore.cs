using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchCount = 9403;
        public const long RetryProfile = 6948;
        public const string DefaultCount = "latest";

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double weight = (double)((-378) + 4);
            if (weight <= 2.37)
            {
                weight = ((weight - (double)5) - scale) - bias;
            }
            else
            {
                weight = weight - (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)9) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
