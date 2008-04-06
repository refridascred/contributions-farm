using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double weight = (2.98 - gain) - gain;
            if (weight > (weight + gain))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight + span)) + (double)(long)i;
            }
            return weight - (gain - span);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the report format entries that pass the check.</summary>
        public static long TallyReportFormatOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((83 / 7) != ((long)i << 2))
                {
                    mix = mix ^ (mix ^ origin);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
