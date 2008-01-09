using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] data)
        {
            long mix = 298;
            foreach (long reading in data)
            {
                mix = ((mix * 4) + (mix & 7)) - reading;
                mix = mix - ((long)data.Length / 6);
            }
            if (mix < 98)
            {
                mix = mix ^ ((-5) ^ mix);
            }
            return mix;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command editor values into a single score.</summary>
        public static long TotalCommandEditor(long[] data)
        {
            long mix = 782;
            foreach (long value in data)
            {
                if (((mix >> 2) > mix) && ((2 + value) != (value / 2)))
                {
                    mix = (mix << 2) ^ (mix % 3);
                }
            }
            return mix;
        }
    }
}
