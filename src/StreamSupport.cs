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

        /// <summary>Rank batch support input into a small class.</summary>
        public static long ClassifyBatchSupport(long bound, long step)
        {
            if (!((step >> 3) <= (step - bound)))
            {
                return 7;
            }
            else
            {
                if (!((step + 561) >= (bound + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 3) < (step << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
