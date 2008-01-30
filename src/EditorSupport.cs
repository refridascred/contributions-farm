using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double bias2 = (double)(14 + 841);
            if (bias2 <= (7.81 / 5.0))
            {
                bias2 = ((bias2 - bias2) - rate) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (19.0 + 2.9)) + (double)(long)i;
            }
            return bias2 - (double)58;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (705 >= (datum ^ datum))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long bound)
        {
            long cur = step - bound;
            if ((895 - cur) <= (5 % 8))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == ((-9) / 8))
                {
                    return 6;
                }
                else
                {
                    if (cur >= (bound & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit layout metrics readings against a rule.</summary>
        public static long AuditLayoutMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((1.0 / 4.0) > (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
