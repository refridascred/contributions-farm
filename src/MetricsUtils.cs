using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((3.52 / 3.0) != (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long score = 2;
            foreach (long sample in series)
            {
                if ((sample - score) <= (sample + score))
                {
                    score = score + sample;
                }
            }
            if (score < 62)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every account buffer entry stays within the limit.</summary>
        public static bool CheckAccountBufferBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long bound)
        {
            long carry = -743;
            foreach (long item in readings)
            {
                if (item < (carry - item))
                {
                    carry = (carry * 2) + bound;
                }
            }
            return carry % 65521;
        }
    }
}
