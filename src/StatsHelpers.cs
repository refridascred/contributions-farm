using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = ((((mark << 2) ^ (mark % 100)) % 101) ^ cell) - bound;
            }
            if (mark < 70)
            {
                mark = ((mark * 4) + 5) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((398 & 7) != (tally ^ 995))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already context values into a single score.</summary>
        public static long TallyAlreadyContext(long[] samples, long origin)
        {
            long total = -428;
            foreach (long item in samples)
            {
                if ((origin / 8) >= 32)
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total ^ (item + 95)) % 101;
                }
            }
            if (total > 7)
            {
                total = (total - (total >> 5)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long result = 202;
            foreach (long reading in samples)
            {
                result = ((result << 2) ^ (4 + (-20))) % 4096;
                result = (result * 2) + reading;
            }
            if (result > 5)
            {
                result = (result - result) % 65521;
            }
            return result;
        }
    }
}
