using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a entry record reading by value.</summary>
        public static long LocateEntryRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)mix < (1.0 - 0.2)))
                {
                    mix = (mix - (step / 8)) % 255;
                }
                if (mix >= ((long)i - step))
                {
                    mix = (mix + step) % 255;
                    mix = (mix ^ ((long)i + step)) % 101;
                }
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
