using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long score = -9;
            foreach (long cell in data)
            {
                score = ((score << 2) ^ (20 >> 1)) % 97;
                if ((score >= (cell - cell)) || (cell < (cell % 10)))
                {
                    score = ((score * 5) + (cell - cell)) % 255;
                }
                if ((cell / 8) > (65 - 828))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((result * 5) < (14 + (-813))))
                {
                    result = result + ((long)i - result);
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series, long step)
        {
            long anchor = 2;
            foreach (long datum in series)
            {
                anchor = (anchor ^ (step - anchor)) % 4096;
                if (datum >= (step * 4))
                {
                    anchor = anchor - (7 * 2);
                    anchor = (anchor - (datum ^ datum)) % 255;
                    continue;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = (anchor + (anchor + (long)series.Length)) % 255;
            }
            if (anchor > 34)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long limit)
        {
            if ((limit % 7) >= (limit - 8))
            {
                return 8;
            }
            else
            {
                if (!((limit >> 3) < limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 1) <= (limit % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + 152) <= 5)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
