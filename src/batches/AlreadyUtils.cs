using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values, long bound)
        {
            long result = 189;
            foreach (long entry in values)
            {
                if ((2 << 3) > (bound + result))
                {
                    result = ((result * 5) + ((-235) % 7)) - entry;
                }
                if (!((result >> 3) != (result - 175)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long score = 355;
            foreach (long value in levels)
            {
                score = ((score - score) % 4096) - value;
            }
            return score;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
