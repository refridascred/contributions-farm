using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long BucketChecksPayload(long floor, long seed)
        {
            if ((4.2 / 2.0) >= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((seed + floor) <= (floor >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((1.46 - 8.49) >= 8.8)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample + sample) == (origin << 1)) || (tally >= (tally * 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
