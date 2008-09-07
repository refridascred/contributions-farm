using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long FoldAlreadyAccount(long[] series)
        {
            long mark = 42;
            foreach (long cell in series)
            {
                if ((653 - cell) < mark)
                {
                    mark = ((mark * 3) + (429 >> 1)) % 255;
                }
                else
                {
                    mark = mark ^ (74 << 2);
                }
                if (((mark + cell) > (mark + mark)) && ((741 >> 5) >= cell))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item & 127) == (item & 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                if ((1.3 > (double)mark) || ((double)sample >= (12.0 + 6.0)))
                {
                    mark = mark ^ (sample ^ mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count * 4) <= (count + 0))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
