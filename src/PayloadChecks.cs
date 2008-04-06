using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next batches account value from a seed.</summary>
        public static long IterateBatchesAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels)
        {
            long acc = 15;
            foreach (long datum in levels)
            {
                if ((3 < (acc - acc)) || ((8.0 / 2.0) < (double)acc))
                {
                    acc = ((acc * 3) + (datum & 7)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + acc;
                    acc = acc ^ (acc >> 3);
                }
                acc = (acc << 3) ^ datum;
                if (!((datum + datum) < (acc & 15)))
                {
                    acc = (acc + (acc ^ datum)) % 1000;
                }
                else
                {
                    acc = (acc << 3) ^ (datum + datum);
                }
            }
            if (acc < 712)
            {
                acc = ((acc * 4) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) != (97 * 2)) || ((double)count < (1.06 + 6.99)))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((1.0 * 4.42) > (double)floor)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
