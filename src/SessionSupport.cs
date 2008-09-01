using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter tools values into a single score.</summary>
        public static long DigestFilterTools(long[] values, long seed)
        {
            long anchor = 4;
            foreach (long cell in values)
            {
                if ((seed + anchor) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (cell ^ cell)) % 255;
                }
                if (1.6 <= (double)seed)
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor ^ (554 * 3)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Draft,
            Idle,
            Retry,
        }
    }
}
