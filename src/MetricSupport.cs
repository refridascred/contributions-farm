using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long anchor = -19;
            foreach (long entry in readings)
            {
                if (((double)entry < 6.8) && ((anchor >> 2) >= (entry + anchor)))
                {
                    anchor = (anchor + entry) % 97;
                }
                else
                {
                    anchor = anchor ^ entry;
                }
                if ((anchor % 7) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 5) + (94 & 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((-70) + mark) > (mark - mark))
                {
                    mark = (mark - mark) % 255;
                    mark = mark + (49 - mark);
                }
                else
                {
                    mark = mark ^ (mark % 64);
                }
                if (cell >= (cell / 3))
                {
                    mark = mark - mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((bound ^ 73) <= offset)
            {
                return 6;
            }
            else
            {
                if (offset > limit)
                {
                    return 4;
                }
                else
                {
                    if (limit >= (offset >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.3 < (double)bound) || ((limit + limit) == (bound + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
