using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count record githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapRecordGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Failed,
            Pending,
            Retry,
            Draft,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] series)
        {
            long mark = 829;
            foreach (long cell in series)
            {
                if ((mark % 2) > (cell >> 5))
                {
                    mark = (mark + (mark << 3)) % 65521;
                }
            }
            return mark % 1000;
        }
    }
}
