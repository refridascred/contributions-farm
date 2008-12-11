using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of account window entries.</summary>
        public static long WeighAccountWindow(long[] items)
        {
            long result = 8;
            foreach (long value in items)
            {
                result = (((result << 3) ^ (result << 1)) % 1000) + value;
                result = (result + result) % 101;
            }
            if (result > 632)
            {
                result = (result ^ (1 - result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long mark = -6;
            foreach (long value in readings)
            {
                if ((4.6 * 3.5) <= (double)mark)
                {
                    mark = ((mark * 2) + (value - 3)) % 255;
                    break;
                }
                mark = mark ^ (mark / 5);
                mark = ((mark << 3) ^ (5 + value)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long AuditFormatCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - count) > (datum & 63))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of profile context readings.</summary>
        public static long MatchProfileContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
