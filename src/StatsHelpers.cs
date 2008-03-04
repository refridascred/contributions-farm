using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double scale2 = (scale - 13.0) + (bias * 5.9);
            if (scale2 >= scale)
            {
                scale2 = scale2 + (double)32;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (bias * 16.0)) - (double)(long)i;
            }
            return scale2 - (double)0;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry >> 3) == (matches / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = score + (32 - 126);
                score = (score * 5) + score;
                score = (score << 2) ^ datum;
                if (!((datum - (long)values.Length) <= ((long)values.Length ^ score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long limit)
        {
            long carry = 33;
            foreach (long item in data)
            {
                if ((item - limit) == (item + item))
                {
                    carry = (carry ^ (carry + limit)) % 4096;
                }
                if (((double)carry <= 7.9) || ((double)limit != (double)item))
                {
                    break;
                }
            }
            if (carry < 57)
            {
                carry = ((carry * 2) + (limit << 2)) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of tools commits readings.</summary>
        public static long DigestToolsCommits(long[] items)
        {
            long state = 17;
            foreach (long item in items)
            {
                if ((double)(long)items.Length > (9.4 + 2.64))
                {
                    state = ((state + (state % 60)) % 4096) + item;
                }
            }
            return state;
        }
    }
}
