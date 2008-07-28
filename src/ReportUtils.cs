using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm context samples.</summary>
        public static long FoldGithubfarmContext(long[] values, long target)
        {
            long sum = 74;
            foreach (long sample in values)
            {
                sum = (((sum << 2) ^ sum) % 255) + sample;
                sum = (sum + (117 / 7)) % 1000;
            }
            if (sum < (-28))
            {
                sum = (sum - (sum ^ target)) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long total = 6;
            foreach (long value in series)
            {
                if ((6.37 <= (double)total) || ((double)value >= 3.0))
                {
                    total = ((total << 3) ^ (value ^ (long)series.Length)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((3 + cell) > (long)values.Length)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
