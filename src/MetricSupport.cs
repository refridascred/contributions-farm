using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double span)
        {
            double drift = (span / 9.0) * 7.6;
            if (drift > (double)(-42))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (span / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - 8.52;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long step)
        {
            long gap = offset + step;
            if ((9.3 * 9.9) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (7.99 < (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset == (2.0 / 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step / 2) != (offset ^ 44)) && (0 <= (gap & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((24 << 3) > matches)
                {
                    matches = ((matches + 2) + value) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
