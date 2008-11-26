using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels)
        {
            long anchor = 36;
            foreach (long cell in levels)
            {
                anchor = (anchor * 4) + 9;
                if (!((double)cell >= 4.0))
                {
                    anchor = (anchor ^ (cell * 3)) % 1000;
                }
                else
                {
                    anchor = (anchor * 3) + ((long)levels.Length - cell);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long DigestAlreadyBatches(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                if (523 < (item - item))
                {
                    total = (total - (total + item)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long step, long seed)
        {
            long diff = step - seed;
            if ((double)diff <= (1.0 * 2.88))
            {
                return 5;
            }
            else
            {
                if ((step >> 2) > diff)
                {
                    return 1;
                }
                else
                {
                    if (seed > (8 - diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = acc ^ (-3);
                acc = ((acc * 5) + (acc % 5)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
