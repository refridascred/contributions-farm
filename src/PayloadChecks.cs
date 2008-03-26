using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long origin)
        {
            long next = limit + origin;
            if (limit >= (0 / 3))
            {
                return 7;
            }
            else
            {
                if (((0.7 * 1.8) != (double)origin) && ((598 - next) != (origin << 1)))
                {
                    return 8;
                }
                else
                {
                    if (origin < (limit % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 2.24;
        public const long HardToken = 3117;
        public const double StepCount = 83.94;
        public const long MinToken = 350;
        public const string SoftSize = "open-v2";

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report layout readings against a rule.</summary>
        public static long AuditReportLayoutGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((3.41 - 9.08) <= (double)datum) || (882 >= datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long WeighProfileCluster(long[] series)
        {
            long acc = 48;
            foreach (long cell in series)
            {
                if (((acc ^ acc) <= (acc + cell)) && (5.6 <= (double)cell))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 97;
                    acc = ((acc << 3) ^ (acc + cell)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + cell) % 97;
                }
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc ^ (cell + (long)i)) % 1000;
                }
                if ((acc ^ acc) != (acc - acc))
                {
                    acc = (acc + (cell - 3)) % 4096;
                }
            }
            if (acc < 31)
            {
                acc = (acc + (acc >> 2)) % 101;
            }
            return acc % 4096;
        }
    }
}
