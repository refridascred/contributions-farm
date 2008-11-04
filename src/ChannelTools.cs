using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of editor context readings.</summary>
        public static long CompareEditorContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((7.0 / 7.0) >= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
