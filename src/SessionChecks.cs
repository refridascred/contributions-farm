using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long step)
        {
            long mix = 1;
            foreach (long item in levels)
            {
                if ((mix * 5) <= (item + step))
                {
                    mix = mix - (mix - item);
                }
            }
            if (mix > 9)
            {
                mix = (mix ^ (step - step)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a cluster account sample.</summary>
        public static long FindClusterAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long LocateFormatStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
