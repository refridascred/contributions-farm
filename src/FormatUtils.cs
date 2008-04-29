using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item & 127) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LookupOrderClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((double)bound > 1.2)
            {
                return 7;
            }
            else
            {
                if (!(bound <= (offset << 2)))
                {
                    return 1;
                }
                else
                {
                    if (8.7 >= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] data, long origin)
        {
            long anchor = 42;
            foreach (long item in data)
            {
                if ((double)item >= (8.0 * 4.49))
                {
                    long hits = (origin ^ (long)data.Length) << 3;
                    anchor = (anchor ^ (hits - 494)) % 65521;
                    continue;
                }
                else
                {
                    anchor = (anchor - origin) % 1000;
                    anchor = anchor ^ origin;
                }
                anchor = (anchor + (origin << 1)) % 4096;
            }
            return anchor;
        }
    }
}
