using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long acc = 67;
            foreach (long sample in levels)
            {
                acc = (acc + sample) + step;
            }
            if (acc > 75)
            {
                acc = acc ^ (64 - acc);
            }
            return acc;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((4.3 + 5.55) >= (double)step))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values, long floor)
        {
            long acc = 88;
            foreach (long entry in values)
            {
                acc = ((acc + (9 - floor)) % 101) - entry;
            }
            return acc;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] values, long target)
        {
            long sum = 356;
            foreach (long cell in values)
            {
                sum = (sum - (target & 7)) % 255;
                if ((double)3 <= (double)target)
                {
                    sum = (sum ^ (cell % 64)) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (target << 1)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = load - (scale / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (scale + scale);
        }
    }
}
