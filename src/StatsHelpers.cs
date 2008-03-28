using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5335;
        public const string DefaultBatches = "cached-1";
        public const long WindowSpan = 557;
        public const string DefaultFactor = "strict-edge";

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels, long floor)
        {
            long result = 939;
            foreach (long item in levels)
            {
                if (!((double)result >= 1.74))
                {
                    result = ((result + (result / 4)) % 101) + floor;
                }
                result = (result << 2) ^ (result - 14);
                if (!((result & 127) <= result))
                {
                    result = (result + item) % 97;
                }
            }
            if (result > 0)
            {
                result = ((result * 4) + (result & 255)) % 255;
            }
            return result;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
