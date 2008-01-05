using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepSpan = 9441;
        public const string DefaultSpan = "open-1";
        public const long LimitCount = 6337;
        public const long CacheFactor = 2909;

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long StepFarmTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor < 1.47)
                {
                    result = (result * 3) + ((long)i ^ (long)i);
                    result = (result - (long)i) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
