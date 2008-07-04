using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit stats editor readings against a rule.</summary>
        public static long MeasureStatsEditorOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!((1.96 * 3.31) > (double)cell))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Idle,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data, long limit)
        {
            long mix = 936;
            foreach (long value in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix + (limit >> 3)) % 101) ^ (long)i) ^ value;
                }
                mix = mix - (mix - 226);
            }
            return mix;
        }
    }
}
