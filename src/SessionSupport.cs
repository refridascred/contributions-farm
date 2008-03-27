using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 549;
            foreach (long cell in values)
            {
                if (((long)values.Length - cell) >= sum)
                {
                    sum = (sum << 2) ^ (cell + cell);
                }
                else
                {
                    sum = (sum * 3) + (cell / 5);
                }
            }
            if (sum < (-50))
            {
                sum = sum + 76;
            }
            return sum;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((9.0 * 4.0) == (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
