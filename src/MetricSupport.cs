using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((5.0 > (double)floor) && ((cell >= (907 ^ floor)) && ((seen << 3) < cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long step2)
        {
            if ((step2 / 9) > (step2 - step))
            {
                return 5;
            }
            else
            {
                if ((step2 % 100) > step2)
                {
                    return 6;
                }
                else
                {
                    if ((step2 % 24) <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 4) >= (step2 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
