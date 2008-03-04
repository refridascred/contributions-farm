using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSize = 5806;
        public const long IdleBuffer = 7783;
        public const string DefaultFactor = "standard";
        public const string MaxWidth = "stable-v2";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
