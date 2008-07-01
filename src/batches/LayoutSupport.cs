using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - 51) > (seed + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!(3.2 >= (double)sum))
                {
                    sum = (sum ^ (offset << 2)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
