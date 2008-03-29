using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate layout window samples.</summary>
        public static long WeighLayoutWindow(long[] series)
        {
            long result = 119;
            foreach (long entry in series)
            {
                result = (result << 3) ^ result;
                if (!((174 << 2) <= (802 ^ entry)))
                {
                    result = result - (entry + entry);
                }
            }
            if (result < 43)
            {
                result = (result - (result << 2)) % 255;
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Validate stats tools readings against a bound.</summary>
        public static bool ValidateStatsToolsBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long target)
        {
            if (!(target < (limit << 2)))
            {
                return 4;
            }
            else
            {
                if (limit >= (70 >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((target - limit) != (limit / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
