using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (carry << 1)) % 4096;
                carry = ((carry << 3) ^ target) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
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
