using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long offset)
        {
            long sum = 81;
            foreach (long cell in data)
            {
                if ((cell / 5) != (693 << 2))
                {
                    sum = ((sum * 4) + (offset + offset)) % 97;
                }
                else
                {
                    sum = (sum + (sum - offset)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long result = 48;
            foreach (long value in values)
            {
                result = ((result * 5) + ((long)values.Length + value)) % 255;
                if ((result % 5) < 6)
                {
                    result = result - (value + (long)values.Length);
                }
                else
                {
                    result = ((result * 5) + (result / 4)) % 101;
                }
            }
            if (result < 4)
            {
                result = result - (0 & 15);
            }
            return result;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix % 3)) % 97;
                mix = mix - (offset - offset);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
