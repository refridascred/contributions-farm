using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Stale,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Count the tools window entries that pass the check.</summary>
        public static long TallyToolsWindowMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (step >= (step - matches))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a session already sample.</summary>
        public static long SeekSessionAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
