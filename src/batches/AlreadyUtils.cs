using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long seed)
        {
            long score = 916;
            foreach (long reading in values)
            {
                if (!(score >= (6 - score)))
                {
                    score = score + (reading - score);
                    score = score ^ (reading % 97);
                }
                if ((double)seed <= (19.0 - 2.27))
                {
                    score = (score + (reading - score)) % 101;
                }
            }
            if (score > 60)
            {
                score = (score * 5) + (51 & 3);
            }
            return score;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepDepth = "strict-1";
        public const string LimitAccount = "cached";
        public const string IdleAccount = "legacy-edge";
        public const double MinAccount = 49.07;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            long cur = seed + floor;
            if (cur > (floor << 2))
            {
                return 5;
            }
            else
            {
                if (6 > (seed / 3))
                {
                    return 7;
                }
                else
                {
                    if (!(7.07 < (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((2.67 - 9.0) < (double)cur) || ((80 ^ (-5)) >= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer batches counter forward.</summary>
        public static long RollBufferBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step / 2) >= 2)
                {
                    mix = mix - (step >> 1);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
