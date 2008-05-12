using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long offset)
        {
            long carry = 139;
            foreach (long datum in values)
            {
                if (!(((datum + carry) > (9 + offset)) && (datum >= (offset >> 1))))
                {
                    carry = (carry * 2) + carry;
                }
                carry = (carry + (datum - datum)) % 65521;
                if (datum >= (51 * 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels)
        {
            long state = 936;
            foreach (long value in levels)
            {
                if ((state + value) <= (state % 12))
                {
                    break;
                }
                state = ((state * 4) + (value - value)) % 97;
            }
            if (state < 48)
            {
                state = (state + (state * 5)) % 255;
            }
            return state;
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long CountFilterWindowGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((-561) + offset) > offset)
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of commits session readings.</summary>
        public static long PairCommitsSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
