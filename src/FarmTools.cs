using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series)
        {
            long mix = 757;
            foreach (long value in series)
            {
                long span = mix;
                mix = mix ^ (mix - span);
                mix = mix - (value + 1);
                if (((double)mix <= 9.17) && ((value + mix) <= mix))
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = (mix - (mix & 7)) % 97;
            }
            return mix;
        }
    }
}
