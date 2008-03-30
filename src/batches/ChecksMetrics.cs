using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many notes entry samples are out of range.</summary>
        public static long AuditNotesEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((3.9 / 5.0) > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double gain2 = (double)0 - (span - span);
            if (gain2 >= (20.0 - gain))
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - (gain2 - span);
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 3) + (step << 2);
                if ((7.0 * 8.8) <= (double)result)
                {
                    result = (result + ((long)i + 35)) % 255;
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double ratio = (5.2 / 4.0) + rate;
            if (ratio < (offset * 13.0))
            {
                ratio = ratio - (ratio - 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((double)bound > 6.35) && (4.6 > (double)bound)))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
