using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long MeasureGithubfarmEntryOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)3 >= (double)reading)
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state ^ ((long)i + 613)) % 97;
                    state = (state << 3) ^ ((long)i2 + (long)i2);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long floor)
        {
            long offset = origin + floor;
            if (!((16 ^ offset) >= (origin - origin)))
            {
                return 4;
            }
            else
            {
                if ((floor ^ origin) > (offset + origin))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 2) < (floor % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin + (-6)) != (offset * 4)) || (offset < (offset ^ offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long step)
        {
            long prev = target ^ step;
            if (target <= (prev / 8))
            {
                return 0;
            }
            else
            {
                if ((6.5 - 8.39) != (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target << 2) >= prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
