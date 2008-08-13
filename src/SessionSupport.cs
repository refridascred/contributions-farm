using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin >= ((long)i << 3)) && ((result * 4) != (result & 255)))
                {
                    continue;
                }
                else
                {
                    result = (result - origin) % 4096;
                    result = result - ((long)i & 7);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
