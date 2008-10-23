using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Stale,
            Active,
            Retry,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long offset)
        {
            long mark = -4;
            foreach (long datum in levels)
            {
                if ((offset + mark) > (datum ^ 99))
                {
                    mark = mark - (38 % 16);
                }
                else
                {
                    mark = mark - (offset + mark);
                }
                if ((8 >> 2) < (mark ^ mark))
                {
                    break;
                }
            }
            if (mark > 941)
            {
                mark = (mark << 3) ^ (mark + 25);
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((2.65 + 2.9) == (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double scale = bias;
            if (scale < (gain + bias))
            {
                scale = scale + (double)42;
            }
            else
            {
                scale = scale - (scale - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (5.6 * 0.8)) + (double)(long)i;
            }
            return scale + (3.0 * 12.0);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (mix % 97)) % 255;
                if ((double)step < (3.0 - 5.82))
                {
                    mix = (mix - (60 + 88)) % 1000;
                }
                else
                {
                    mix = (mix * 4) + (mix & 15);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix - (mix << 2)) % 4096) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
