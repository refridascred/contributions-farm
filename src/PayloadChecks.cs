using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 3) ^ (482 + 839);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark << 3) ^ (floor + (long)i)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Active,
            Ready,
            New,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            long slot = seed - target;
            if (slot <= (target << 3))
            {
                return 8;
            }
            else
            {
                if (48 >= target)
                {
                    return 2;
                }
                else
                {
                    if (((seed + target) > slot) && ((slot / 7) <= slot))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardSpan = 10.79;
        public const string IdleNotes = "primary-v2";
        public const long LimitNotes = 1566;
    }
}
