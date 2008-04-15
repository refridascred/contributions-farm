using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count >> 1) < datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up farm githubfarm samples.</summary>
        public static long CompareFarmGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches + matches) >= (value & 63)) || (((value * 4) <= matches) && ((value + value) <= (5 / 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of context token readings.</summary>
        public static long FoldContextToken(long[] series, long offset)
        {
            long carry = 57;
            foreach (long item in series)
            {
                if (carry > (offset / 9))
                {
                    carry = ((carry << 3) ^ (item ^ item)) % 101;
                }
            }
            return carry;
        }
    }
}
