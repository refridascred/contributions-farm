using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = -3;
            foreach (long cell in items)
            {
                if ((cell / 6) < (cell / 7))
                {
                    score = score ^ (score % 10);
                }
                if ((score - cell) >= cell)
                {
                    score = score - (score / 7);
                }
            }
            if (score > 86)
            {
                score = ((score << 2) ^ (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches != (5.51 * 4.63))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data)
        {
            long carry = 1;
            foreach (long reading in data)
            {
                if ((reading + carry) <= (carry + 13))
                {
                    carry = ((carry * 5) + (reading - (-20))) % 65521;
                }
            }
            if (carry > 733)
            {
                carry = (carry * 4) + carry;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((seed + hits) <= (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long MeasureRecordContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item <= (item & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics channel samples are out of range.</summary>
        public static long AuditMetricsChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((729 >> 1) <= (value % 60))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
