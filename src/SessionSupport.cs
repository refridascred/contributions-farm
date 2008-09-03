using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count the already record entries that pass the check.</summary>
        public static long MeasureAlreadyRecordOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((14.0 >= (double)count) && ((datum >> 3) <= 9))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Rank { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
