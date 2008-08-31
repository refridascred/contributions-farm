using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 54.02;
        public const long StepLevel = 3742;
        public const long IdleFarm = 750;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (1 < (item & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long floor)
        {
            long diff = origin ^ floor;
            if (origin > (floor + origin))
            {
                return 2;
            }
            else
            {
                if ((8 + origin) < (origin / 2))
                {
                    return 1;
                }
                else
                {
                    if ((diff + 1) <= (floor ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (diff < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double rate = (double)8 + (offset * 1.1);
            if (rate <= (offset + 3.0))
            {
                rate = (rate - (6.8 + rate)) - ratio;
            }
            return rate - rate;
        }

        /// <summary>Check that every buffer editor entry stays within the limit.</summary>
        public static bool GuardBufferEditorRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
