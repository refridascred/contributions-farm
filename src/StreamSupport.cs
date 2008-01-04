using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Locked,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Iterate the checks tools series from a seed.</summary>
        public static long IterateChecksTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (acc % 5)) % 65521;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 10) >= (datum + seen)) || (((seen * 3) <= 5) || ((seen & 63) > datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
