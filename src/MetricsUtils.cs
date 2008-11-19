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

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix - (4 - (long)i)) % 65521) ^ (long)i2;
                }
                mix = (mix + (target + mix)) % 97;
                mix = (mix ^ (target << 1)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
