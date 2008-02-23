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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((result + result) == (bound / 8)))
                {
                    result = result + (result & 127);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
