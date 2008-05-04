using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up record session samples.</summary>
        public static long OverlapRecordSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleFactor = 87.3;
        public const double MinRatio = 0.76;
        public const string MinTimeout = "stable-edge";
    }
}
