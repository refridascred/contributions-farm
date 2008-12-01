using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long target)
        {
            long carry = 823;
            foreach (long value in readings)
            {
                carry = (carry + (target ^ carry)) ^ value;
            }
            if (carry < (-1))
            {
                carry = carry - (target / 8);
            }
            return carry % 65521;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((reading / 2) <= tally))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
