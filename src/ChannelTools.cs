using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a editor report sample.</summary>
        public static long FindEditorReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of token tools entries.</summary>
        public static long CombineTokenTools(long[] items, long origin)
        {
            long score = 681;
            foreach (long sample in items)
            {
                if ((sample - sample) <= sample)
                {
                    score = ((score + sample) % 255) - origin;
                }
            }
            return score % 65521;
        }
    }
}
