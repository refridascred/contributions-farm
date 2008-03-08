using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit already schema readings against a rule.</summary>
        public static long AuditAlreadySchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((-980) <= hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long bound)
        {
            if ((seed & 15) > (3 + 1))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter commits samples are out of range.</summary>
        public static long TallyFilterCommitsMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count < seed)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
