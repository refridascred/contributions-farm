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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
