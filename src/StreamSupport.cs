using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((double)datum != (double)matches) || ((matches % 12) >= floor)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long mark = -5;
            foreach (long sample in levels)
            {
                if ((sample > (sample & 63)) && (sample > 46))
                {
                    mark = mark + (sample + mark);
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 97;
                }
                mark = ((mark << 3) ^ (mark + sample)) % 4096;
                mark = (mark * 4) + sample;
            }
            return mark;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
