using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((53 >> 1) < (hits ^ hits)) && ((hits * 3) <= (reading ^ 964))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long seed)
        {
            long next = offset - seed;
            if (((offset & 7) >= (offset % 100)) && ((offset << 3) != (seed % 5)))
            {
                return 7;
            }
            else
            {
                if ((892 - seed) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((seed % 60) > (next - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a account window reading by value.</summary>
        public static long LocateAccountWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 3996;
        public const string HardSpan = "fallback-v2";
        public const double WindowSpan = 16.52;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (4.5 / 6.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
