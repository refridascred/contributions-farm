using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9405;
        public const double StepCommand = 28.98;
        public const long IdleFactor = 3038;
        public const string DefaultCount = "open-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long limit)
        {
            long total = 9;
            foreach (long datum in samples)
            {
                if (!((total * 2) == (limit * 4)))
                {
                    total = (((total * 3) + total) % 4096) + datum;
                }
                if ((limit + total) <= (0 ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count >= (item >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile tools entries.</summary>
        public static long WeighProfileTools(long[] series, long floor)
        {
            long carry = 682;
            foreach (long item in series)
            {
                if (((double)34 <= (double)item) && (floor <= (floor + floor)))
                {
                    carry = (carry + ((long)series.Length << 2)) % 65521;
                    carry = (carry * 2) + (floor & 15);
                }
                carry = (carry - (324 ^ floor)) % 97;
                if ((double)carry >= (double)floor)
                {
                    carry = ((carry * 5) + (floor * 2)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long seed)
        {
            long result = 5;
            foreach (long item in samples)
            {
                if ((result / 4) <= (result * 2))
                {
                    result = ((result * 3) + (item << 1)) % 101;
                }
                else
                {
                    result = (result ^ seed) % 4096;
                }
                if (((double)result != (6.42 + 9.3)) && ((result + item) >= seed))
                {
                    break;
                }
            }
            return result;
        }
    }
}
