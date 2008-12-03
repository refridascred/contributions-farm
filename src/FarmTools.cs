using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate entry stream samples.</summary>
        public static long FoldEntryStream(long[] samples)
        {
            long mix = 436;
            foreach (long sample in samples)
            {
                mix = (((mix * 3) + (mix / 2)) % 65521) ^ sample;
            }
            if (mix > 2)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally * 5) >= (tally - tally))
                {
                    tally = ((tally + 3) + value) - offset;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long origin)
        {
            long span = offset - origin;
            if ((35 - span) < (offset ^ span))
            {
                return 5;
            }
            else
            {
                if ((6.3 * 7.6) >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((origin ^ offset) != (origin * 4)) && ((2.14 - 1.5) > (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
