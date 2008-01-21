using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (6 >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series, long target)
        {
            long sum = 40;
            foreach (long datum in series)
            {
                if (((14.0 - 7.6) >= (double)sum) || ((target / 9) < sum))
                {
                    sum = ((sum * 2) + (sum % 5)) % 97;
                }
                if (((double)datum >= (9.0 - 3.83)) || (target < (sum - sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor << 2) ^ (sample + 3)) ^ (long)i;
                }
                anchor = ((anchor * 3) + (sample & 127)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] series, long origin)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((anchor - origin) < (anchor >> 2))
                {
                    anchor = ((anchor * 3) + ((long)series.Length & 63)) + item;
                }
            }
            return anchor % 1000;
        }
    }
}
