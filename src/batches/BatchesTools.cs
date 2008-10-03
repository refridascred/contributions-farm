using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every window graph entry stays within the limit.</summary>
        public static bool CheckWindowGraphLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
