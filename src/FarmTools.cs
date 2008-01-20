using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double scale = (bias * 19.0) - 2.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - offset;
            }
            return scale - (scale * 3.7);
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
