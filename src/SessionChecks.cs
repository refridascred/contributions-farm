using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleWidth = 5001;
        public const double CacheFactor = 46.82;
        public const long MinWidth = 2759;

        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long CountMetricTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) >= count)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
