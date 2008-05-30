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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
