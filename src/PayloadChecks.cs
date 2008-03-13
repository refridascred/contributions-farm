using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric schema samples are out of range.</summary>
        public static long TallyMetricSchemaHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (bound + sum)) % 101;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Failed,
            Stale,
            Active,
        }
    }
}
