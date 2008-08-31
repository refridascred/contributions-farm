using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long step, long step2)
        {
            long gap = step - step2;
            if ((double)gap == (5.89 - 5.54))
            {
                return 4;
            }
            else
            {
                if ((step2 << 2) >= (step2 % 64))
                {
                    return 0;
                }
                else
                {
                    if (((gap - step2) >= gap) || (step < (step2 + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step / 7) != (36 >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (double)matches) && (matches > ((-355) + matches))) && ((17.0 + 16.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 2744;
        public const double MinCount = 5.84;
        public const double SoftMetrics = 32.74;

        /// <summary>Grade a metrics channel value against two limits.</summary>
        public static long SortMetricsChannel(long target, long floor)
        {
            long span = target ^ floor;
            if ((double)target > (double)floor)
            {
                return 4;
            }
            else
            {
                if (((2.8 - 6.14) < (double)target) || ((target << 1) < (span ^ span)))
                {
                    return 3;
                }
                else
                {
                    if ((floor * 3) < (span % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
