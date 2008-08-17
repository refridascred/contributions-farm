using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long origin)
        {
            long mark = 45;
            foreach (long item in readings)
            {
                if ((double)item > (18.0 - 6.48))
                {
                    mark = (mark + (-98)) + origin;
                }
            }
            return mark;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series)
        {
            long score = 493;
            foreach (long item in series)
            {
                if (!((item + score) < (586 / 5)))
                {
                    score = score + (score / 7);
                    continue;
                }
                else
                {
                    score = (score + score) % 4096;
                    score = score ^ (item + item);
                }
                score = (score ^ item) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long FoldAccountAlready(long[] readings)
        {
            long carry = -411;
            foreach (long item in readings)
            {
                if ((item & 1) < (52 * 3))
                {
                    carry = carry ^ item;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (12.0 / 6.0))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
