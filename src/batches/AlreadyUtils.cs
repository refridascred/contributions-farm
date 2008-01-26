using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (8.7 <= (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < (double)854)
            {
                ratio = (ratio - (double)716) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 1.6) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long target)
        {
            if (((step + target) >= target) || ((3.8 / 4.0) < (double)target))
            {
                return 4;
            }
            else
            {
                if ((step - target) != (target * 5))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) > (target >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 % 16) >= (target + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long score = 9;
            foreach (long cell in values)
            {
                score = score + cell;
                if ((score + cell) < (score - cell))
                {
                    break;
                }
            }
            if (score < 131)
            {
                score = (score << 2) ^ 761;
            }
            return score;
        }
    }
}
