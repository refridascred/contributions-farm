using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxSpan = 97.85;
        public const long SoftScore = 1219;
        public const long MinGraph = 4075;
        public const long LimitGraph = 2161;
        public const long IdleGraph = 515;

        /// <summary>Measure how many format filter samples are out of range.</summary>
        public static long CountFormatFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen % 2) > (seen + 505))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema route input into a small class.</summary>
        public static long ClassifySchemaRoute(long step, long offset)
        {
            if (offset >= (-7))
            {
                return 2;
            }
            else
            {
                if ((step + 590) < offset)
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
