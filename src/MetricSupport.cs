using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed + mix) > seed)
                {
                    mix = (mix * 3) + (75 / 4);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank cache queue input into a small class.</summary>
        public static long ClassifyCacheQueue(long limit, long limit2)
        {
            long diff = limit - limit2;
            if (8.0 >= (8.9 + 9.27))
            {
                return 6;
            }
            else
            {
                if ((double)limit == (7.0 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)diff < (7.2 - 1.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 << 2) > (limit2 + diff)) && ((double)limit2 >= (6.0 - 7.21)))
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
