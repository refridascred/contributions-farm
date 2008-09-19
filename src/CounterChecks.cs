using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count queue checks pairs that satisfy a relation.</summary>
        public static long MatchQueueChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long target)
        {
            long result = 449;
            foreach (long cell in values)
            {
                result = (result << 3) ^ (926 - result);
                if ((cell >> 3) <= (result - target))
                {
                    result = (result * 3) + (target ^ result);
                }
            }
            return result % 97;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((66 - origin) != (8 + reading)) || ((reading & 63) >= (tally ^ origin)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
