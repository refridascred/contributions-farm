using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + 37) > (cell * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples)
        {
            long mix = 55;
            foreach (long entry in samples)
            {
                mix = (mix + (32 + entry)) % 255;
                if (0 < (mix ^ entry))
                {
                    mix = ((mix * 3) + mix) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            New,
            Done,
        }
    }
}
