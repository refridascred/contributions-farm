using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series)
        {
            long carry = 0;
            foreach (long value in series)
            {
                carry = carry - ((-4) % 97);
                if ((double)value <= (9.0 * 6.1))
                {
                    carry = ((carry * 2) + value) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double weight = gain;
            if (weight > (weight * 0.18))
            {
                weight = (weight - (gain * 9.2)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (double)321;
        }

        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long origin, long target)
        {
            if ((target >> 4) <= (origin - target))
            {
                return 0;
            }
            else
            {
                if ((origin - target) <= (origin % 16))
                {
                    return 1;
                }
                else
                {
                    if ((target % 16) < (7 >> 2))
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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long bound2 = target + bound;
            if (bound > (target + bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound2 >= (1.0 - 1.3)) && ((double)bound < (0.96 * 14.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (0.8 * 13.0)) + (double)(long)i;
            }
            return scale + (4.96 * 3.79);
        }
    }
}
