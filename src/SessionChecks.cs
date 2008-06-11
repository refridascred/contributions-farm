using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 98.71;
        public const string LimitQueue = "standard-1";
        public const long SoftTimeout = 3279;
        public const long MinSize = 5023;
        public const double SoftQueue = 9.01;

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                mix = (mix + (entry << 3)) + offset;
            }
            return mix;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double rate = (double)(59 % 16);
            return ((rate + (double)151) + ratio) + floor;
        }
    }
}
