using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] readings)
        {
            long state = -652;
            foreach (long item in readings)
            {
                if (item > ((long)readings.Length + 3))
                {
                    state = ((state << 3) ^ state) % 97;
                }
                else
                {
                    state = ((state * 4) + state) % 255;
                }
                if (((13.0 - 1.0) != (double)item) && ((state * 2) >= (item << 2)))
                {
                    state = ((state << 2) ^ (item + item)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((offset - (long)i) <= (offset ^ (long)i)))
                {
                    anchor = ((anchor * 4) + (long)i) % 255;
                }
                anchor = ((anchor * 4) + (anchor / 8)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double ratio = (weight + weight) - 8.9;
            if (ratio <= (weight + 7.45))
            {
                ratio = (ratio + (ratio + ratio)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)43) + (double)(long)i;
            }
            return ratio + 5.56;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
