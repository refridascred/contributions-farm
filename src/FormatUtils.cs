using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "standard-edge";
        public const long MaxBudget = 3550;
        public const long BatchPayload = 7338;

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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
