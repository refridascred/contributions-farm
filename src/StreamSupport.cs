using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long carry = 638;
            foreach (long reading in items)
            {
                carry = ((carry << 3) ^ (origin - carry)) - reading;
            }
            if (carry < 43)
            {
                carry = (carry << 2) ^ (origin + carry);
            }
            return carry % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
