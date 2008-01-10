using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long GradeEditorCommits(long bound, long origin)
        {
            if (bound > (origin >> 1))
            {
                return 1;
            }
            else
            {
                if (!((origin >> 1) >= (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((origin - bound) != (1 >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin % 60) <= (877 ^ 439))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((double)hits <= (4.1 * 4.73)) || ((long)levels.Length != (sample & 255))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session stream samples.</summary>
        public static long ScoreSessionStream(long[] readings, long origin)
        {
            long mix = -62;
            foreach (long datum in readings)
            {
                mix = ((mix - (origin % 24)) % 101) ^ datum;
            }
            if (mix > 734)
            {
                mix = ((mix * 5) + (5 + mix)) % 1000;
            }
            return mix;
        }
    }
}
