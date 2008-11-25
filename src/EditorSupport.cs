using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Locked,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool ValidateMetricsEntryRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally >= (double)seed)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
