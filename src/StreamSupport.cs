using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the format record series from a seed.</summary>
        public static long RollFormatRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                if (floor >= ((long)i * 5))
                {
                    result = (result - ((long)i >> 3)) % 65521;
                    continue;
                }
                else
                {
                    result = (result ^ (floor + floor)) % 1000;
                    result = ((result * 5) + (result << 1)) % 4096;
                }
                result = ((result * 2) + (result + result)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long bound)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if (((bound + anchor) <= ((long)series.Length + reading)) || ((anchor - anchor) < reading))
                {
                    anchor = ((anchor << 3) ^ (reading + bound)) % 255;
                }
                if (((bound >> 5) >= (bound + (-407))) || ((reading & 127) >= reading))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Active,
            Draft,
        }
    }
}
