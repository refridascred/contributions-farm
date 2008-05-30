using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the layout editor series from a seed.</summary>
        public static long RollLayoutEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstRatio = 6333;
        public const double MinCount = 77.87;
        public const double SoftSpan = 51.55;
        public const long StepWidth = 6391;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long mix = 950;
            foreach (long value in data)
            {
                if ((value + (long)data.Length) < mix)
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = mix + (362 + value);
                }
            }
            return mix % 1000;
        }
    }
}
