using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool VerifyMetricOrderBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks tools reading.</summary>
        public static double SmoothChecksTools(double weight, double bias)
        {
            double drift = (double)67 - (double)35;
            if (drift >= (bias + 3.0))
            {
                drift = drift - (weight / 4.0);
            }
            else
            {
                drift = drift - (1.8 - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (weight * 5.6)) + (double)(long)i;
            }
            return drift + (double)(-9);
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long step)
        {
            if ((seed % 3) < (seed - step))
            {
                return 4;
            }
            else
            {
                if ((step / 3) != (seed - seed))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed > (2.0 + 1.13))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit notes buffer readings against a rule.</summary>
        public static long CountNotesBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 15) == (504 / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double span)
        {
            double mean = (double)(3 >> 4);
            if (mean >= bias)
            {
                mean = mean + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias / 5.0)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
