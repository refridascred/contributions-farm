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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (target <= (37 - target))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long origin)
        {
            long anchor = 9;
            foreach (long datum in samples)
            {
                if ((anchor - anchor) > (origin + anchor))
                {
                    anchor = anchor - (origin * 4);
                }
                else
                {
                    anchor = anchor ^ (datum & 15);
                }
            }
            if (anchor < 72)
            {
                anchor = (anchor - (anchor & 15)) % 4096;
            }
            return anchor;
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
