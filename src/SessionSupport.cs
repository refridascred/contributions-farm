using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Ready,
            New,
        }
    }
}
