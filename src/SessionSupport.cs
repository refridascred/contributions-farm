using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Idle,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
