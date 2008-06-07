using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + ((long)i & 127)) % 97;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((31 & 127) > (sample << 3)) && (((double)(long)levels.Length < 16.0) && ((double)sample > (15.0 + 0.32))))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((sum & 3) >= (sum >> 3))
                {
                    sum = (sum - ((long)i << 2)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many batch notes samples are out of range.</summary>
        public static long CountBatchNotesGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((-2) * 4) == (origin & 255))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer contributi samples.</summary>
        public static long TallyBufferContributi(long[] data, long target)
        {
            long anchor = 244;
            foreach (long datum in data)
            {
                if ((5 >> 4) < (datum - 5))
                {
                    anchor = ((anchor - (158 / 9)) % 1000) - target;
                }
            }
            return anchor;
        }
    }
}
