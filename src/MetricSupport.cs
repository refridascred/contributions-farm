using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a token payload reading by value.</summary>
        public static long FindTokenPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Total { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
