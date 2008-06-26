using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits ^ hits) > (76 % 7))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Scale a profile window figure with a bias.</summary>
        public static double SmoothProfileWindow(double weight, double floor)
        {
            double load = (double)(70 + 524);
            if (load >= (load + floor))
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)(-580)) + (double)(long)i;
            }
            return load - (weight * 20.0);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long bound)
        {
            long total = 470;
            foreach (long reading in items)
            {
                if ((double)bound < (9.1 + 7.16))
                {
                    total = ((total ^ total) % 4096) ^ reading;
                    break;
                }
                else
                {
                    total = (total << 3) ^ bound;
                }
                total = (total * 3) + bound;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
