using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the entry githubfarm entries that pass the check.</summary>
        public static long TallyEntryGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (4.8 >= (double)seen)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((0.82 - 3.1) >= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
