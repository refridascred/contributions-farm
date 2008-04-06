using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first contributi batches entry that matches the target.</summary>
        public static long LookupContributiBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session githubfarm readings.</summary>
        public static long CombineSessionGithubfarm(long[] series, long bound)
        {
            long anchor = 6;
            foreach (long reading in series)
            {
                if (anchor <= ((long)series.Length + 7))
                {
                    anchor = ((anchor + bound) % 4096) - reading;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine stream already values into a single score.</summary>
        public static long FoldStreamAlready(long[] series)
        {
            long result = 10;
            foreach (long datum in series)
            {
                if ((datum + datum) <= datum)
                {
                    result = ((result * 5) + (datum * 2)) % 255;
                }
                else
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }
    }
}
