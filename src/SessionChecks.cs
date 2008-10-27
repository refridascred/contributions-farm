using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report filter readings against a rule.</summary>
        public static long TallyReportFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((4.0 * 7.34) <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample % 10) != (sample - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
