using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels)
        {
            long state = 349;
            foreach (long sample in levels)
            {
                if ((double)sample < (2.16 + 8.4))
                {
                    state = state + (sample + sample);
                }
            }
            return state;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mix = 15;
            foreach (long item in readings)
            {
                mix = (mix + (13 + mix)) % 101;
                mix = (mix - (mix + item)) % 4096;
                if ((mix << 2) != (mix + mix))
                {
                    mix = mix ^ (item & 31);
                }
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 972;
        public const double SoftBudget = 95.06;
        public const long BaseRatio = 7970;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches >> 3) < 400) || ((3.0 / 3.0) > (double)step)) && ((step >= 197) || ((5 * 3) == (reading - reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long step2)
        {
            long bound = step + step2;
            if ((step2 - bound) < step)
            {
                return 4;
            }
            else
            {
                if ((5.6 + 9.54) >= (double)step2)
                {
                    return 3;
                }
                else
                {
                    if ((1.27 * 5.52) != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 <= (step2 - bound)) || ((74 + step2) < (step2 & 63)))
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
    }
}
