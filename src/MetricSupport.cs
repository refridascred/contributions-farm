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

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Draft,
            Stale,
            Pending,
        }
    }
}
