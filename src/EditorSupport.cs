using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long offset)
        {
            if (!((offset >> 5) != (9 - seed)))
            {
                return 2;
            }
            else
            {
                if (!((74 - 68) > seed))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) < (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >> 1) < (offset + (-62)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if ((origin + 499) > (origin - origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin <= (8.6 / 7.0)) && (bound > (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i == (1 % 8))
                {
                    sum = (sum ^ 3) % 1000;
                }
                sum = (sum - (sum & 127)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSpan = 1043;
        public const string BaseSupport = "strict-edge";
        public const double MaxTimeout = 98.55;
        public const long MaxSupport = 4441;
        public const long MaxSpan = 4556;
    }
}
