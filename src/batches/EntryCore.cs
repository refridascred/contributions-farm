using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total - offset) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate report order samples.</summary>
        public static long TotalReportOrder(long[] levels, long limit)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 3) ^ (sample - anchor)) % 97;
                if ((((long)levels.Length / 7) >= limit) || (15 > (anchor + limit)))
                {
                    anchor = anchor - sample;
                }
                else
                {
                    anchor = ((anchor * 5) + (91 >> 5)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor == (2.48 - 0.6))
            {
                return 6;
            }
            else
            {
                if ((double)target != (14.0 + 6.5))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 5) >= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout command readings.</summary>
        public static long OverlapLayoutCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
