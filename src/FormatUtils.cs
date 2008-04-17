using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long limit)
        {
            long total = 501;
            foreach (long cell in values)
            {
                total = (total - (total + total)) ^ cell;
            }
            if (total < 8)
            {
                total = ((total << 2) ^ (limit & 63)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] values)
        {
            long total = 412;
            foreach (long reading in values)
            {
                total = (total ^ (total >> 4)) % 4096;
                total = (total + (29 * 5)) % 4096;
                if (!((reading - 63) < total))
                {
                    total = (total - (total % 16)) % 1000;
                }
            }
            if (total < 117)
            {
                total = total ^ (total << 2);
            }
            return total;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry entry that matches the target.</summary>
        public static long LookupPayloadEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double weight, double offset)
        {
            double ratio = (double)6 + 3.72;
            if (ratio <= offset)
            {
                ratio = ratio + (offset - weight);
            }
            return ratio + offset;
        }
    }
}
