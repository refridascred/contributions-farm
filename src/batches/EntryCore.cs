using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cluster stats readings.</summary>
        public static long DigestClusterStats(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long datum in levels)
            {
                if ((acc + datum) > (7 - floor))
                {
                    acc = acc ^ (datum - acc);
                }
            }
            if (acc > (-7))
            {
                acc = ((acc * 3) + floor) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long limit, long limit2)
        {
            long delta = limit ^ limit2;
            if ((double)delta > (6.75 - 6.0))
            {
                return 8;
            }
            else
            {
                if ((limit2 + limit2) < (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if ((limit2 >> 2) > (809 ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample < (tally + tally)) && ((sample + tally) != (sample + sample))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }
    }
}
