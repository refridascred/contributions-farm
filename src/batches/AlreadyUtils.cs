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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (13.0 - 2.0))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

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
