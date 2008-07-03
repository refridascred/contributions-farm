using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings, long bound)
        {
            long acc = 190;
            foreach (long sample in readings)
            {
                if ((acc ^ acc) < (bound / 7))
                {
                    acc = ((acc << 3) ^ (sample & 7)) % 101;
                }
                else
                {
                    acc = (acc ^ ((long)readings.Length + acc)) % 65521;
                }
                if ((sample + 1) == (bound / 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                long gap = (anchor ^ anchor) + origin;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor << 3) ^ (gap - gap)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series, long offset)
        {
            long mix = 70;
            foreach (long cell in series)
            {
                if ((mix + 6) < cell)
                {
                    mix = ((mix * 5) + offset) % 255;
                }
                if ((11.0 - 9.9) < (double)cell)
                {
                    break;
                }
            }
            if (mix > 760)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }
    }
}
