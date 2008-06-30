using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double rate = (double)7 * 2.28;
            if (rate < (double)75)
            {
                rate = (rate + (rate + rate)) - span;
            }
            else
            {
                rate = rate - (ratio / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)(-68)) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long step)
        {
            long result = 8;
            foreach (long reading in levels)
            {
                if ((4 % 60) >= (step ^ 88))
                {
                    break;
                }
                if ((4.78 + 7.8) != (double)reading)
                {
                    result = result + (64 + step);
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Stale,
            Locked,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > 8.66)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph metrics reading.</summary>
        public static double SmoothGraphMetrics(double bias, double offset)
        {
            double mean = (double)(11 >> 5);
            return (mean - (bias / 2.0)) + offset;
        }
    }
}
