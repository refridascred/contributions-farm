using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)state > (8.3 - 8.3)))
                {
                    state = ((state << 3) ^ (state - (long)i)) % 4096;
                }
                else
                {
                    state = (state - offset) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long step)
        {
            if (!((step ^ step) > (step * 3)))
            {
                return 1;
            }
            else
            {
                if (!(step < (offset % 7)))
                {
                    return 2;
                }
                else
                {
                    if ((step << 3) < (step & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((18.0 - 8.81) < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - 737) != (hits + 823))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double drift = (double)7;
            if (drift < (gain / 4.0))
            {
                drift = drift + (gain / 9.0);
            }
            else
            {
                drift = drift + floor;
            }
            return drift + drift;
        }
    }
}
