using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (3 <= (hits & 127))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 1312;
        public const string BaseSession = "local";
        public const long CacheInterval = 9957;

        /// <summary>Count githubfarm buffer pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long SortBufferReport(long target, long step)
        {
            if (!((double)target <= 17.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ 889) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((898 >= step) || (step > (3 - target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples, long limit)
        {
            long acc = 14;
            foreach (long value in samples)
            {
                acc = ((acc ^ value) % 1000) - limit;
            }
            return acc % 4096;
        }
    }
}
