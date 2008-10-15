using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many buffer format samples are out of range.</summary>
        public static long TallyBufferFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + seen) <= (datum / 5)) && !((seen & 1) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + floor) != (datum / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
