using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long target)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                acc = ((acc ^ (acc - sample)) % 101) - target;
                if (sample < (sample << 1))
                {
                    acc = (acc << 2) ^ (sample % 8);
                }
                else
                {
                    acc = acc ^ (7 & 3);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
