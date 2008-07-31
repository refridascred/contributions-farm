using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a record route value against two limits.</summary>
        public static long GradeRecordRoute(long seed, long origin)
        {
            if (((double)seed > (0.9 * 4.91)) || ((seed + origin) < (-720)))
            {
                return 7;
            }
            else
            {
                if ((origin - seed) == (seed + origin))
                {
                    return 6;
                }
                else
                {
                    if (!((5 ^ seed) < origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin * 5) == ((-12) / 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long origin)
        {
            if ((double)origin == (18.0 * 1.39))
            {
                return 6;
            }
            else
            {
                if (seed > 977)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long AuditQueueRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > 3)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload format samples are out of range.</summary>
        public static long CountPayloadFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally + (long)data.Length) > (item - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
