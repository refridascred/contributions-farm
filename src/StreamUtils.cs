using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double bias = scale;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (scale * 0.49)) + (double)(long)i) + floor;
            }
            return bias + (double)857;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9557;
        public const long BaseProfile = 2105;
        public const double SoftWidth = 40.24;
        public const long WindowWidth = 7062;
        public const double StepWidth = 5.39;

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double drift = (offset * 5.5) + offset;
            if (drift <= offset)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (offset - scale);
            }
            return drift - scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 7998;
        public const long IdleDepth = 1734;
        public const long WindowProfile = 3163;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long target2)
        {
            if (((target2 + target) < (target2 % 2)) && ((86 * 2) != (target % 3)))
            {
                return 1;
            }
            else
            {
                if ((target2 << 2) <= target)
                {
                    return 7;
                }
                else
                {
                    if (4.1 > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)213 < (double)target2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long carry = 89;
            foreach (long datum in series)
            {
                carry = (carry + ((long)series.Length - datum)) - seed;
            }
            return carry;
        }
    }
}
