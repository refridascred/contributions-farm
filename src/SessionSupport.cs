using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches * 2) != (4 << 3)) || (((5 + matches) != (4 - 92)) && ((matches - sample) > (matches & 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
