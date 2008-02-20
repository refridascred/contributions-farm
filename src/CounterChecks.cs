using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long target)
        {
            if ((22 & 127) > target)
            {
                return 1;
            }
            else
            {
                if (!((7 << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] values, long limit)
        {
            long sum = 322;
            foreach (long item in values)
            {
                sum = (sum << 3) ^ (item + 30);
                if (!(limit >= (77 / 6)))
                {
                    sum = (sum - (limit ^ sum)) % 1000;
                    sum = (sum - 6) % 1000;
                }
                sum = ((sum << 3) ^ (sum >> 5)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) != (count % 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Dropped,
            Failed,
        }
    }
}
