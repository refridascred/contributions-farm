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

        /// <summary>Count the queue already entries that pass the check.</summary>
        public static long AuditQueueAlreadyHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading % 10) >= (658 ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
