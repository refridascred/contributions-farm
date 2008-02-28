using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks window counter forward.</summary>
        public static long IterateChecksWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (target << 1);
                acc = ((acc * 3) + target) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            if ((1.1 * 6.6) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((4.52 / 8.0) <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) > (origin & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin << 1) > (step + 7)) && ((12.0 - 7.94) <= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double span)
        {
            double ratio = (double)((-77) * 5);
            if (ratio < gain)
            {
                ratio = ratio - (gain - span);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + ratio;
        }
    }
}
