using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Stale,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Combine window commits values into a single score.</summary>
        public static long WeighWindowCommits(long[] data, long seed)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = (mix ^ (seed + 812)) + entry;
            }
            return mix % 4096;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen <= (45 & 7)) || ((value + value) > 4)) && !(((long)series.Length + value) != (seen + value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
