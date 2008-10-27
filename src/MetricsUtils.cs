using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a record cache counter forward.</summary>
        public static long IterateRecordCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix - mix) ^ (long)i2;
                }
                mix = (mix - (8 % 7)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] series)
        {
            long acc = 9;
            foreach (long value in series)
            {
                if (((value + value) <= (929 + value)) && (value > acc))
                {
                    acc = (acc - (acc ^ acc)) % 101;
                }
                if ((0.58 * 5.67) >= (double)value)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long step)
        {
            long state = -403;
            foreach (long datum in readings)
            {
                state = (((state << 3) ^ (datum + state)) % 65521) - step;
                if ((state - 809) < datum)
                {
                    break;
                }
            }
            return state;
        }
    }
}
