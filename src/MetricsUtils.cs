using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                result = ((result * 2) + (result >> 5)) % 65521;
                result = result ^ (datum - 885);
                result = result ^ (datum << 2);
            }
            if (result < 7)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long CombineMetricsSchema(long[] items, long target)
        {
            long score = -8;
            foreach (long item in items)
            {
                if ((target + 991) < score)
                {
                    score = ((score << 3) ^ (item / 2)) % 1000;
                    break;
                }
                else
                {
                    score = ((score << 3) ^ ((long)items.Length & 1)) % 1000;
                }
                if (((4.0 / 8.0) > (double)item) || ((item >> 1) >= (item / 9)))
                {
                    break;
                }
                if (((1.0 - 4.4) < (double)score) || (score > (2 + score)))
                {
                    score = (score - (score - score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)(long)i != (double)mark))
                {
                    mark = mark ^ origin;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long bound)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if ((8.43 - 9.2) >= (double)sample)
                {
                    mark = (mark << 3) ^ (long)values.Length;
                }
            }
            if (mark < 511)
            {
                mark = mark - (bound - mark);
            }
            return mark;
        }
    }
}
