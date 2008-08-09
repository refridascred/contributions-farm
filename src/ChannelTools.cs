using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long bound, long limit)
        {
            long prev = bound - limit;
            if (((limit * 4) < (limit % 7)) && (7 > (limit + 623)))
            {
                return 7;
            }
            else
            {
                if ((prev >> 5) < (prev + (-20)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 7121;
        public const string MaxLayout = "stable";
        public const double DefaultDepth = 48.8;
        public const long SoftSize = 4423;
        public const double LimitSpan = 35.9;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels, long origin)
        {
            long total = 55;
            foreach (long cell in levels)
            {
                total = total ^ 301;
                if (cell > total)
                {
                    total = (total * 2) + (origin / 2);
                }
            }
            if (total > 20)
            {
                total = ((total * 3) + (origin % 60)) % 4096;
            }
            return total;
        }
    }
}
