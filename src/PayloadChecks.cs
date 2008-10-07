using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if ((reading % 5) != (sum & 15))
                {
                    sum = (sum << 3) ^ (reading & 15);
                }
                if ((double)sum > (3.79 + 18.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long sum = 710;
            foreach (long value in readings)
            {
                sum = (sum * 3) + (value * 4);
                sum = ((sum * 5) + (sum + (long)readings.Length)) % 65521;
            }
            if (sum > (-54))
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (bound > seen)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
