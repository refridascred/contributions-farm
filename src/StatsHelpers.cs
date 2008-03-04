using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
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

        /// <summary>Adjust a report commits reading.</summary>
        public static double AdjustReportCommits(double bias, double offset)
        {
            double ratio = (18.0 * 12.0) + (double)(-64);
            if (ratio <= (double)2)
            {
                ratio = ratio - offset;
            }
            return ratio + (bias * 12.0);
        }
    }
}
