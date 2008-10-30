using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                if ((4 - 498) < item)
                {
                    sum = (sum + item) % 101;
                }
            }
            if (sum < 458)
            {
                sum = (sum ^ origin) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark * 2) == (mark + step)))
                {
                    mark = (mark << 3) ^ (mark >> 1);
                    mark = (mark ^ step) % 101;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen * 2) == (value ^ seen))
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
    }
}
