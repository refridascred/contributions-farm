using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long anchor = 56;
            foreach (long entry in series)
            {
                if (anchor <= (entry ^ entry))
                {
                    anchor = (anchor ^ (8 + anchor)) % 101;
                }
            }
            if (anchor < 10)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((double)seen < (6.4 / 2.0)) && ((datum + seen) < (-618))) || (402 >= (datum / 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long step, long limit)
        {
            long offset = step - limit;
            if (((offset * 5) >= (offset % 60)) || ((384 & 127) <= offset))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (step & 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset > (7.9 * 1.82))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
