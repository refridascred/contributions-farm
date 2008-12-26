using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long offset)
        {
            long delta = floor + offset;
            if (delta <= (offset + 586))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) == (offset * 5))
                {
                    return 0;
                }
                else
                {
                    if (((floor * 5) <= delta) || ((floor >> 4) < (0 >> 2)))
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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < (gain2 - span))
            {
                gain2 = gain2 + (gain2 - span);
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (9.0 + gain2);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
