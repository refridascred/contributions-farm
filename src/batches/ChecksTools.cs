using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double mean = offset;
            if (mean > bias)
            {
                mean = mean - (offset - offset);
            }
            return mean - (offset - bias);
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Pending,
            Retry,
            Idle,
        }
    }
}
