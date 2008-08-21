using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)limit < (10.0 * 2.25))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long OverlapPayloadEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 73.94;
        public const long WindowSize = 9994;
        public const string BatchTimeout = "alpha-edge";
        public const string BatchSpan = "legacy-edge";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3731;
        public const long MinGithubfarm = 4463;
        public const long BaseInterval = 629;
        public const long MaxScore = 4100;
        public const double MaxSpan = 5.76;
    }
}
