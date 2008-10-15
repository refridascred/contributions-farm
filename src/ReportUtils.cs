using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long score = 90;
            foreach (long entry in samples)
            {
                if ((3.0 - 20.0) == (double)entry)
                {
                    score = ((score << 3) ^ (score % 3)) % 4096;
                }
                score = score ^ (score & 127);
                if ((entry & 15) < score)
                {
                    score = ((score * 2) + (entry * 4)) % 97;
                }
            }
            if (score > 24)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long seed)
        {
            if ((origin << 3) < (origin + seed))
            {
                return 1;
            }
            else
            {
                if ((6.64 / 6.0) == (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed - 954) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= (14.0 - 7.63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((offset / 9) >= offset))
                {
                    sum = (sum - (35 << 3)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
