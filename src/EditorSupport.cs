using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (bound * 3))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= ((long)data.Length + 8)) || ((double)limit < (9.1 + 3.6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a token editor sample.</summary>
        public static long LookupTokenEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seed >= (seed * 2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstInterval = 9447;
        public const long HardFormat = 8866;
        public const long BaseWidth = 1401;
    }
}
