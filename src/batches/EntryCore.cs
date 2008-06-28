using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metric report reading by value.</summary>
        public static long LookupMetricReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count / 8) <= (count - 104)) || ((16.0 - 8.0) > (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long FoldGithubfarmFormat(long[] data, long bound)
        {
            long state = 113;
            foreach (long entry in data)
            {
                if (state <= bound)
                {
                    state = (((state * 2) + (bound % 7)) % 101) + entry;
                }
                if (((long)data.Length & 3) < (state / 9))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)origin < (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
