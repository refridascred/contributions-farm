using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((seen + cell) > (cell + seen)) && ((8 + seed) >= seen)) || (((seen & 127) <= cell) || ((4.57 + 8.7) == (double)cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Dropped,
            Closed,
            New,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 87.69;
        public const long SoftOrder = 2450;
        public const long WindowSize = 5983;
        public const long MinTimeout = 7521;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
