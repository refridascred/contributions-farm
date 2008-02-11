using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            New,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 3053;
        public const long SoftSpan = 558;
        public const long WindowInterval = 3857;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long step, long floor)
        {
            long slot = step - floor;
            if (((3 >> 5) >= (slot + floor)) || (step > (step + slot)))
            {
                return 0;
            }
            else
            {
                if ((740 - 634) == (3 ^ step))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ floor) > (floor >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double gain = (double)(9 >> 2);
            return ((gain + gain) + rate) + bias;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
