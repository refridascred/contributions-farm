using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if (offset >= ((long)i >> 2))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long CombineNotesRoute(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ 8) % 101) ^ entry;
            }
            return result % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long target)
        {
            long bound = limit ^ target;
            if (limit >= (target - target))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (6.0 + 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (double)limit)
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
}
