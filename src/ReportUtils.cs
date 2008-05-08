using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (cell + seen))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Synced,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(((83 / 3) > seen) || (item <= (item ^ seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
