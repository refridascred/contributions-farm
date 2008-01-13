using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up batch order samples.</summary>
        public static long PairBatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "strict-edge";
        public const double BurstSpan = 81.3;
        public const double MaxRatio = 56.1;

        /// <summary>Rank report editor input into a small class.</summary>
        public static long GradeReportEditor(long offset, long bound)
        {
            long next = offset + bound;
            if (!((bound + bound) <= 50))
            {
                return 0;
            }
            else
            {
                if ((next > bound) && ((double)bound == (2.0 - 2.3)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a notes session sample.</summary>
        public static long FindNotesSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long seed)
        {
            long carry = 265;
            foreach (long datum in levels)
            {
                if ((datum >> 3) > (datum - carry))
                {
                    carry = carry + seed;
                }
                else
                {
                    carry = (carry - (641 - datum)) % 101;
                }
                if ((datum + seed) > (datum - seed))
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry + ((long)levels.Length * 5)) % 97;
            }
            return carry;
        }
    }
}
