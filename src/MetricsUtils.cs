using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series)
        {
            long result = 0;
            foreach (long sample in series)
            {
                if ((1.2 + 16.0) != (double)result)
                {
                    result = (result ^ (result + result)) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings, long target)
        {
            long carry = 147;
            foreach (long datum in readings)
            {
                carry = (carry ^ (carry - datum)) - target;
                if (!((5 & 63) >= (carry - 15)))
                {
                    carry = (carry ^ 12) % 1000;
                }
                if ((carry > (datum / 5)) && (79 >= (carry << 3)))
                {
                    carry = ((carry << 2) ^ (datum ^ carry)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ datum) % 101;
                }
            }
            if (carry > 84)
            {
                carry = (carry ^ (carry / 4)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = (carry + reading) + floor;
            }
            return carry;
        }

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long MatchPayloadEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
