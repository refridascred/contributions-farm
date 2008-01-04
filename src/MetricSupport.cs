using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long origin)
        {
            if (6 > origin)
            {
                return 6;
            }
            else
            {
                if ((double)step != (2.7 + 4.9))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count metrics cluster pairs that satisfy a relation.</summary>
        public static long PairMetricsClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
