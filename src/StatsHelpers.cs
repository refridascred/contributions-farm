using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell + (-43)) == (count * 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long score = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (19.0 + 1.0))
                {
                    score = score ^ (datum ^ 0);
                }
            }
            if (score > 46)
            {
                score = (score ^ score) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long carry = 94;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)carry)
                {
                    carry = ((carry * 4) + carry) % 65521;
                }
                else
                {
                    carry = carry - (carry / 3);
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) != (datum >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
