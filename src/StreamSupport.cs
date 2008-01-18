using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally & 15) != (tally % 7))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinWidth = 25.05;
        public const long WindowContributi = 3954;
        public const long MinContributi = 1219;
    }
}
