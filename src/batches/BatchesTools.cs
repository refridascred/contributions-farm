using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long floor)
        {
            long mix = 482;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix << 3) ^ mix) % 4096) ^ (long)i;
                }
                if ((floor << 1) >= (mix + cell))
                {
                    mix = ((mix << 2) ^ (floor + (long)series.Length)) % 1000;
                }
                else
                {
                    mix = (mix * 4) + (floor + floor);
                }
                if ((mix <= (mix - mix)) || ((mix >> 3) >= (608 + 7)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long seed, long offset)
        {
            if (((double)seed < (14.0 + 17.0)) || (seed > 76))
            {
                return 3;
            }
            else
            {
                if ((offset % 24) != (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((124 - (-5)) >= (seed % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Closed,
            Active,
        }
    }
}
