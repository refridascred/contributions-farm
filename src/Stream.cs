using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long origin2)
        {
            if (((double)origin2 > (5.71 + 18.0)) && ((864 + origin) >= origin))
            {
                return 3;
            }
            else
            {
                if (((origin - origin2) > ((-755) - 27)) || ((origin + 38) < origin))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin2 < (13.0 / 6.0)) || ((8.0 / 8.0) < (double)origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 85.97;
        public const long IdleSize = 4856;
        public const double BaseInterval = 56.17;
    }
}
