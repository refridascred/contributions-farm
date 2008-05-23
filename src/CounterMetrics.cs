using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
