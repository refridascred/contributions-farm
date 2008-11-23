using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (offset / 8)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count graph filter pairs that satisfy a relation.</summary>
        public static long OverlapGraphFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings)
        {
            long mark = 33;
            foreach (long reading in readings)
            {
                if ((mark < (mark - mark)) && ((1.13 / 5.0) == (double)reading))
                {
                    mark = (mark - (mark + (-77))) % 4096;
                }
            }
            if (mark < 36)
            {
                mark = (mark * 5) + (mark << 3);
            }
            return mark % 65521;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (((mark * 5) + (offset % 97)) % 4096) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
