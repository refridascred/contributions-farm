using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 55;
            foreach (long cell in samples)
            {
                if (((score + cell) > 0) || ((10.0 + 3.0) <= (double)cell))
                {
                    score = (score << 2) ^ (cell & 3);
                }
            }
            return score;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] values)
        {
            long acc = 304;
            foreach (long datum in values)
            {
                if ((acc + 194) >= acc)
                {
                    break;
                }
                acc = (acc ^ 1) - datum;
            }
            return acc;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if ((7 >= (target + target)) && ((target - (long)i) != ((long)i + acc)))
                {
                    acc = (acc + 61) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
