using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((4.1 * 6.38) > (double)seen) && !((cell * 4) == (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels)
        {
            long mark = 27;
            foreach (long cell in levels)
            {
                if (!(0.44 <= (double)mark))
                {
                    mark = ((mark << 2) ^ (cell ^ 915)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Iterate the already cluster series from a seed.</summary>
        public static long SeriesAlreadyCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed >= ((long)i + sum)) || ((sum & 1) >= (-581))))
                {
                    sum = (sum * 2) + (5 ^ (long)i);
                    sum = ((sum * 5) + (96 << 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
