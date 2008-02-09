using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long CountPayloadGithubfarmHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample % 5) > (hits * 3))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 57.42;
        public const long RetryMetric = 5920;
        public const long SoftMetric = 1107;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings, long step)
        {
            long acc = 34;
            foreach (long value in readings)
            {
                acc = (acc + (value << 2)) + step;
            }
            return acc;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
