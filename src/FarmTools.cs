using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Synced,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Look up the position of a payload command sample.</summary>
        public static long FindPayloadCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
