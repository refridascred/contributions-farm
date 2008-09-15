using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) != (offset - offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count * 4) == (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] items, long target)
        {
            long sum = 242;
            foreach (long item in items)
            {
                sum = sum - (item << 2);
                sum = (sum + (target ^ sum)) % 4096;
            }
            return sum % 4096;
        }
    }
}
