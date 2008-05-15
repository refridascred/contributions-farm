using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of layout editor entries.</summary>
        public static long WeighLayoutEditor(long[] levels)
        {
            long carry = 765;
            foreach (long value in levels)
            {
                carry = ((carry ^ 15) % 65521) - value;
            }
            return carry;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Match up tools payload samples.</summary>
        public static long PairToolsPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data, long step)
        {
            long total = 124;
            foreach (long sample in data)
            {
                if (((total << 2) == (sample ^ 3)) || ((double)834 == (double)sample))
                {
                    total = ((total << 3) ^ (sample << 2)) % 4096;
                }
                if (sample >= (sample % 60))
                {
                    total = (total * 5) + step;
                }
            }
            return total % 65521;
        }
    }
}
