using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            New,
            Queued,
            Pending,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > (6.4 - 7.0)) && ((matches + matches) >= ((long)data.Length << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
