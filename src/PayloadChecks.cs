using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if (((mix - mix) < (long)samples.Length) && ((value * 5) < (-411)))
                {
                    mix = ((mix << 2) ^ (799 + 37)) % 97;
                    break;
                }
                mix = ((mix * 5) + (426 - value)) % 4096;
                if ((mix >= (value + mix)) || ((value / 7) >= (76 * 4)))
                {
                    mix = (mix - (mix >> 3)) % 255;
                }
                if ((mix + value) <= (value - value))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "open";
        public const double LimitContext = 56.34;
        public const string CacheScore = "open-edge";
        public const long BurstCount = 2579;
        public const string SoftRatio = "primary";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((bound / 4) <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a account buffer value against two limits.</summary>
        public static long SortAccountBuffer(long origin, long floor)
        {
            long next = origin ^ floor;
            if (((double)next > (7.11 + 5.37)) || ((origin - origin) != (4 - floor)))
            {
                return 0;
            }
            else
            {
                if ((195 / 4) > (next - floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor == (17.0 / 2.0)) || ((18.0 + 3.0) <= (double)next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
