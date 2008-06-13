using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long step)
        {
            if ((double)step == (4.66 * 1.71))
            {
                return 1;
            }
            else
            {
                if (step < (step - origin))
                {
                    return 6;
                }
                else
                {
                    if (!(8.0 >= (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
