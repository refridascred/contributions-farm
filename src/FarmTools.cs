using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long limit)
        {
            long mix = 899;
            foreach (long datum in samples)
            {
                if (limit >= mix)
                {
                    mix = mix + datum;
                }
                else
                {
                    mix = (mix ^ (89 * 4)) % 97;
                }
            }
            if (mix > (-745))
            {
                mix = mix ^ limit;
            }
            return mix;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long CombineStreamContext(long[] readings, long target)
        {
            long carry = 18;
            foreach (long sample in readings)
            {
                carry = (((carry + (carry % 10)) % 1000) + sample) + target;
            }
            return carry % 97;
        }
    }
}
