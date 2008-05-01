using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool GuardContextFilterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long seed)
        {
            long step = origin + seed;
            if ((step + step) > step)
            {
                return 1;
            }
            else
            {
                if ((step + origin) < (seed - 388))
                {
                    return 6;
                }
                else
                {
                    if (((327 << 1) < (seed * 5)) || ((origin << 1) <= (origin ^ seed)))
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

        /// <summary>Validate support payload readings against a bound.</summary>
        public static bool CheckSupportPayloadLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Derive the next schema cache value from a seed.</summary>
        public static long DeriveSchemaCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((16.0 - 5.2) == (double)acc) && ((origin >> 4) >= (acc ^ 4)))
                {
                    acc = ((acc * 5) + acc) % 97;
                }
                else
                {
                    acc = ((acc * 2) + (long)i) % 255;
                }
                acc = acc + ((long)i - origin);
                acc = ((acc * 4) + acc) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
