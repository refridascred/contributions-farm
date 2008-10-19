using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate payload filter samples.</summary>
        public static long TotalPayloadFilter(long[] levels)
        {
            long anchor = 18;
            foreach (long datum in levels)
            {
                anchor = ((anchor << 3) ^ anchor) ^ datum;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
