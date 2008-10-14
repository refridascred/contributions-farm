using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter buffer sample.</summary>
        public static long LookupFilterBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long MeasureGithubfarmAccountHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((5.63 + 1.5) == (double)entry) || ((tally * 5) >= (entry - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if ((double)origin == (double)target)
            {
                return 5;
            }
            else
            {
                if ((origin + origin) >= ((-20) - origin))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) < 20)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
