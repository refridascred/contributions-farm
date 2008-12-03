using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitSpan = "fallback";
        public const long MaxBudget = 8409;
        public const string LimitLevel = "strict-1";
        public const string IdleRatio = "local-edge";
        public const long MaxBuffer = 2841;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading % 3) < (reading * 2))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((-23) / 9) < (hits - hits)) || (((double)hits <= 15.0) && ((double)reading <= (14.0 * 1.7))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload farm samples.</summary>
        public static long TallyPayloadFarm(long[] series)
        {
            long mix = 3;
            foreach (long value in series)
            {
                if ((double)mix != (7.89 * 3.5))
                {
                    mix = ((mix * 4) + (-14)) % 4096;
                }
                if ((3.02 / 2.0) != (double)mix)
                {
                    mix = ((mix * 4) + (98 - value)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (5 % 60)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool CheckCommandSchemaBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
