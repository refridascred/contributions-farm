using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data)
        {
            long mix = 408;
            foreach (long cell in data)
            {
                mix = (mix * 4) + 20;
                if ((cell > (cell - (long)data.Length)) || (0 < (cell * 2)))
                {
                    mix = mix - (cell / 3);
                }
                else
                {
                    mix = (mix * 5) + (cell << 3);
                }
            }
            if (mix > 30)
            {
                mix = (mix - mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long seed)
        {
            long anchor = 83;
            foreach (long cell in readings)
            {
                if ((double)cell >= (10.0 / 8.0))
                {
                    anchor = ((anchor * 4) + (70 % 10)) % 1000;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 2) + (seed / 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((score ^ origin) != (origin >> 1))
                {
                    score = (score - (origin ^ origin)) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score * 2) + (7 + origin)) % 97) ^ (long)i2;
                    score = (score - origin) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen > (8.6 * 8.43))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
