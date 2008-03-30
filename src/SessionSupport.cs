using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the already layout series from a seed.</summary>
        public static long SeriesAlreadyLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ mark) % 255;
                if ((long)i > floor)
                {
                    mark = mark ^ (mark / 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches * 2) != (matches - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
