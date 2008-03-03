using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a layout counter sample.</summary>
        public static long LocateLayoutCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long floor, long seed)
        {
            if (((522 >> 2) < seed) && (floor < seed))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) > seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
