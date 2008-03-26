using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long offset)
        {
            if ((2.8 + 5.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((bound & 7) > bound)
                {
                    return 5;
                }
                else
                {
                    if ((offset + bound) > (offset >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset < (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double ratio = gain;
            if (ratio < ratio)
            {
                ratio = (ratio - (2.5 / 2.0)) - bias;
            }
            else
            {
                ratio = ratio - (9.1 + gain);
            }
            return ratio - (gain + 3.1);
        }
    }
}
