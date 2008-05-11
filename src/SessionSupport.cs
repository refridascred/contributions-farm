using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4723;
        public const long SoftTimeout = 7506;
        public const long MaxSpan = 9249;
        public const long LimitGraph = 8781;
        public const long WindowScore = 1577;

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples, long bound)
        {
            long mix = 82;
            foreach (long value in samples)
            {
                mix = (mix ^ (bound + mix)) % 65521;
                if (!((0.1 * 5.0) > (double)value))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
