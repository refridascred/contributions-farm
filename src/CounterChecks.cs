using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally <= 3.0)
                {
                    tally = ((tally + 1) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph already samples are out of range.</summary>
        public static long MeasureGraphAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (2.8 * 2.86))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i >> 3) < score))
                {
                    score = ((score << 2) ^ (limit / 8)) % 255;
                    score = ((score * 5) + (limit * 3)) % 97;
                    break;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long TotalOrderCounter(long[] series)
        {
            long anchor = 14;
            foreach (long datum in series)
            {
                anchor = (anchor - (3 + anchor)) ^ datum;
                anchor = (anchor << 3) ^ 7;
            }
            if (anchor < 8)
            {
                anchor = (anchor - (anchor * 5)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6821;
        public const long HardChecks = 814;
        public const double BaseCount = 18.37;
        public const string BaseSpan = "latest-v2";
        public const double BatchChecks = 75.79;
    }
}
