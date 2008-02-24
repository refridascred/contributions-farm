using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate order format samples.</summary>
        public static long CombineOrderFormat(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry / 3) < 2)
                {
                    score = ((score * 2) + (93 ^ entry)) % 1000;
                }
                score = (score ^ (score + entry)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Blend two schema layout measurements.</summary>
        public static double ScaleSchemaLayout(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (bias * 5.0))
            {
                rate = rate + (double)9;
            }
            return rate - ratio;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((offset & 7) == (reading - reading)) && ((reading + reading) <= (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
