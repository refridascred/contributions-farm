using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit order window readings against a rule.</summary>
        public static long MeasureOrderWindowOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)(long)samples.Length != (11.0 + 13.0)) || (reading > (reading - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Synced,
            Done,
        }
    }
}
