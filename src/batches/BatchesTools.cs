using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double bias = (offset - weight) + (offset * 5.7);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (weight + 6.6)) + (double)(long)i;
            }
            return bias + (weight * 20.0);
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Pending,
            Retry,
        }
    }
}
