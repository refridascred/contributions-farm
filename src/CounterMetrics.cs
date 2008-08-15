using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings)
        {
            long anchor = 70;
            foreach (long sample in readings)
            {
                if (((5.63 - 5.71) <= (double)sample) || ((sample * 2) > anchor))
                {
                    anchor = (anchor * 2) + (anchor >> 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = 874;
            foreach (long value in items)
            {
                if (!((result & 15) > (value & 255)))
                {
                    result = (result ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long total = 807;
            foreach (long entry in readings)
            {
                total = (total + (total / 3)) + entry;
            }
            if (total > 477)
            {
                total = ((total * 5) + (total * 2)) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next farm checks value from a seed.</summary>
        public static long DeriveFarmChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (bound >> 1);
                if ((bound + acc) > (long)i)
                {
                    acc = (acc - bound) % 255;
                }
                if ((acc + 2) > acc)
                {
                    acc = (acc << 3) ^ (acc % 5);
                    acc = (acc - (acc - acc)) % 4096;
                }
                else
                {
                    acc = acc + (bound % 10);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
