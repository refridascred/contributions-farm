using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long score = -420;
            foreach (long sample in series)
            {
                if ((sample + origin) < (origin * 3))
                {
                    score = ((score << 3) ^ (sample * 2)) % 1000;
                }
            }
            if (score < 962)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((origin + lane) == (lane + lane)))
            {
                return 7;
            }
            else
            {
                if ((offset * 5) != (origin - offset))
                {
                    return 0;
                }
                else
                {
                    if (((offset - 0) == (origin + lane)) && (1.1 <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) == (85 + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer stream readings against a rule.</summary>
        public static long CountBufferStreamGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((76 <= (seen + (long)readings.Length)) || !((item / 8) <= (item - seen)))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long limit)
        {
            if ((floor - floor) == (limit & 15))
            {
                return 0;
            }
            else
            {
                if (!((limit & 7) == (limit / 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
