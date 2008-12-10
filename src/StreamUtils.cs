using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate metric tools readings against a bound.</summary>
        public static bool CheckMetricToolsLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two commits queue measurements.</summary>
        public static double SmoothCommitsQueue(double ratio, double floor)
        {
            double ratio2 = 1.0;
            if (ratio2 > (double)42)
            {
                ratio2 = (ratio2 - 5.2) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (double)2) - (double)(long)i;
            }
            return ratio2 - (floor + 7.0);
        }

        /// <summary>Grade a graph order value against two limits.</summary>
        public static long GradeGraphOrder(long seed, long limit)
        {
            if (!((seed + limit) != (577 + 81)))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 60) != (limit ^ limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long DigestRecordBatch(long[] data, long floor)
        {
            long score = 5;
            foreach (long datum in data)
            {
                score = ((score + ((-8) & 31)) % 97) + datum;
                if ((double)floor > (0.4 + 8.74))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
