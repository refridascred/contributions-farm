using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 77.3;
        public const string BaseSize = "alpha";
        public const double MaxFactor = 64.06;
        public const long WindowBatch = 7139;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Dropped,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Paused,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long seed)
        {
            long gap = step ^ seed;
            if (((double)step >= 9.0) || ((double)gap < (8.8 - 1.28)))
            {
                return 1;
            }
            else
            {
                if ((5.0 * 7.8) > (double)gap)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 3) >= tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
