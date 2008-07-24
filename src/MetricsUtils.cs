using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long offset, long offset2)
        {
            if (offset >= (offset % 16))
            {
                return 3;
            }
            else
            {
                if (((offset + offset) >= (offset2 + offset2)) || ((offset * 4) == (offset / 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - value) > (69 + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long score = 641;
            foreach (long value in data)
            {
                if (floor < (value % 3))
                {
                    score = (score ^ value) % 65521;
                    continue;
                }
                score = ((score << 3) ^ value) % 65521;
                if ((floor >> 3) > 6)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items)
        {
            long acc = 207;
            foreach (long cell in items)
            {
                acc = acc ^ (cell + cell);
                if (!((acc + acc) == ((-7) % 100)))
                {
                    acc = (acc + (cell * 2)) % 65521;
                }
                if (!((cell % 5) < cell))
                {
                    acc = acc - 2;
                }
            }
            return acc;
        }
    }
}
