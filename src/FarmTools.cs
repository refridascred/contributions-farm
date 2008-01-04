using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a metric commits reading.</summary>
        public static double ScaleMetricCommits(double rate, double offset)
        {
            double drift = offset * 7.0;
            if (drift > (double)64)
            {
                drift = (drift - 4.7) - rate;
            }
            return drift + offset;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long step2)
        {
            long step3 = step - step2;
            if (step <= (step3 & 127))
            {
                return 1;
            }
            else
            {
                if ((step3 - step) < (step3 + step2))
                {
                    return 2;
                }
                else
                {
                    if (step2 < (step << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step & 3) <= 789) || ((double)step2 >= (9.0 * 6.4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
