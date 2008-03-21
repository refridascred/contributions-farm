using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate order cache readings against a bound.</summary>
        public static bool VerifyOrderCacheLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total + 3)) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i != (seed ^ total))
                {
                    break;
                }
                else
                {
                    long delta = 35 - (seed & 31);
                    total = (total ^ (total + delta)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long origin)
        {
            if ((3 % 2) <= (limit + origin))
            {
                return 3;
            }
            else
            {
                if (6 <= origin)
                {
                    return 2;
                }
                else
                {
                    if (!((origin & 1) >= 39))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
