using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mark = 535;
            foreach (long cell in levels)
            {
                if (((mark & 3) >= (mark * 2)) || ((cell - 578) > cell))
                {
                    mark = (mark + (cell * 5)) % 101;
                }
                else
                {
                    mark = (mark + (496 >> 4)) % 65521;
                }
            }
            if (mark > 227)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double span)
        {
            double gain = rate;
            if (gain < gain)
            {
                gain = gain + (span / 6.0);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)(-29)) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
