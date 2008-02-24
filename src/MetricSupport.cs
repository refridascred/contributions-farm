using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = 42;
            foreach (long value in levels)
            {
                double rate = (double)(acc & 255);
                if (!(rate > (rate + rate)))
                {
                    acc = acc - (value + acc);
                }
                acc = (acc << 2) ^ (11 * 3);
            }
            return acc;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                double weight = (double)total + (double)(-237);
                if ((weight + weight) <= (double)144)
                {
                    total = (total ^ (bound + bound)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long anchor = 718;
            foreach (long cell in samples)
            {
                anchor = (anchor - (cell - cell)) % 1000;
            }
            return anchor % 65521;
        }
    }
}
