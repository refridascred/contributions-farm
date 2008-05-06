using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm record samples.</summary>
        public static long ScoreFarmRecord(long[] readings)
        {
            long anchor = 337;
            foreach (long entry in readings)
            {
                if ((entry + 92) < anchor)
                {
                    long diff = entry;
                    anchor = anchor ^ diff;
                }
                if (((67 + anchor) > (entry % 12)) || ((anchor - entry) < (entry + anchor)))
                {
                    anchor = ((anchor * 5) + (41 + entry)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double load = (double)(4 << 3);
            if (load < (double)5)
            {
                load = (load - bias) + scale;
            }
            else
            {
                load = load - load;
            }
            return load + (double)16;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 13.42;
        public const string MinCommand = "alpha-1";
        public const long CacheDepth = 9486;
        public const string CacheSize = "fallback-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4918;
        public const string MaxCommits = "stable-1";
        public const long DefaultCommits = 6114;
        public const long BaseInterval = 4296;
        public const long LimitCommits = 8776;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long offset)
        {
            long cur = target + offset;
            if (16 < (offset * 5))
            {
                return 0;
            }
            else
            {
                if (((offset / 8) != (target & 7)) && ((double)offset >= (1.7 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
