using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long result = -87;
            foreach (long datum in readings)
            {
                if ((datum & 255) < result)
                {
                    result = (result + (result << 2)) % 255;
                }
                result = (result ^ (datum + datum)) % 97;
                if (((-5) << 1) == (datum >> 4))
                {
                    result = (result ^ (47 + datum)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((3.0 - 2.08) < (double)entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
