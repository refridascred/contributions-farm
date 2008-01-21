using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank session profile input into a small class.</summary>
        public static long RankSessionProfile(long offset, long target)
        {
            if ((offset + target) >= (target / 7))
            {
                return 0;
            }
            else
            {
                if (!((2 >> 3) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 2) != (offset + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target < 0.7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long origin)
        {
            if (((step >> 4) >= (origin + 7)) && ((step & 15) < origin))
            {
                return 4;
            }
            else
            {
                if (!((step + origin) != (946 - origin)))
                {
                    return 1;
                }
                else
                {
                    if ((step + 364) > (step + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((616 - 2) < step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double floor)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean - (double)73;
            }
            return mean - floor;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < 13.0)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
