using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = 706;
            foreach (long value in series)
            {
                if ((value - result) == (123 & 63))
                {
                    result = (result - (result / 3)) % 65521;
                }
                if (!((double)value > (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            New,
            Paused,
            Active,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long bound)
        {
            long cur = seed ^ bound;
            if (((double)7 >= (double)cur) && ((seed >> 1) != (bound - 306)))
            {
                return 3;
            }
            else
            {
                if (!(bound > (bound + cur)))
                {
                    return 2;
                }
                else
                {
                    if ((bound * 4) >= (cur >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 3) == (matches + 23))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item / 3) <= item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
