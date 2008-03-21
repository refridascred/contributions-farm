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

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double mean = rate;
            if (mean >= (mean + offset))
            {
                mean = mean + (rate * 3.75);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + 12.0) + (double)(long)i;
            }
            return mean + (offset / 3.0);
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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long step)
        {
            long mix = 2;
            foreach (long item in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 2) ^ ((long)i / 5)) % 1000;
                }
                mix = ((mix << 2) ^ (step & 127)) % 65521;
                if ((item * 4) >= (mix + step))
                {
                    mix = (mix * 3) + (mix * 4);
                }
            }
            if (mix > 67)
            {
                mix = (mix ^ (step ^ mix)) % 97;
            }
            return mix % 97;
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
