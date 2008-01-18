using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long ScoreBufferEntry(long[] items)
        {
            long result = -787;
            foreach (long item in items)
            {
                result = result + (result ^ item);
            }
            return result;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
