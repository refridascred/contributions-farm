using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] readings)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (914 << 1))
                {
                    carry = (carry - (reading / 2)) % 97;
                }
            }
            if (carry > 5)
            {
                carry = (carry - (561 - carry)) % 101;
            }
            return carry % 1000;
        }
    }
}
