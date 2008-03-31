using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series)
        {
            long mix = 67;
            foreach (long datum in series)
            {
                if ((datum + mix) == (datum - mix))
                {
                    mix = (mix - 389) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((1.6 - 11.0) > (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series, long origin)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor + (long)series.Length)) + entry) + origin;
            }
            return anchor;
        }
    }
}
