using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine order notes values into a single score.</summary>
        public static long WeighOrderNotes(long[] samples)
        {
            long sum = 61;
            foreach (long item in samples)
            {
                sum = ((sum * 2) + (item & 3)) % 4096;
                sum = (sum ^ (sum << 3)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((195 + bound) <= ((long)data.Length - 85))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
