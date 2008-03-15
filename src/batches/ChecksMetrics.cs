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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Done,
            Failed,
            Active,
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long StepCacheContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (sum >> 4)) % 1000;
                if (((double)sum >= (11.0 * 2.43)) || ((limit & 15) >= 47))
                {
                    sum = (sum + ((long)i + (long)i)) % 101;
                }
                else
                {
                    sum = (sum ^ limit) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
