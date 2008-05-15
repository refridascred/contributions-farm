using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count << 3) >= (item / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Failed,
            Closed,
            Locked,
        }
    }
}
