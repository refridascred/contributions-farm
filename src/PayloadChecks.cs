using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double gain = 5.94;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + span) + (double)(long)i) + rate;
            }
            return gain - span;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double mean = scale * 2.6;
            return (mean + (6.5 / 9.0)) + floor;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (limit >= (94 - (long)i))
                {
                    anchor = (anchor + (96 / 9)) % 255;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor + (1 / 2)) % 255) ^ (long)i2;
                }
                if ((double)anchor >= (7.2 / 5.0))
                {
                    anchor = ((anchor << 2) ^ (limit ^ anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            if ((6.9 * 7.0) == (double)origin)
            {
                return 5;
            }
            else
            {
                if (bound < (bound + origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (6.0 - 0.96))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin < ((-3) * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
