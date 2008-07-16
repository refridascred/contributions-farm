using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((limit + 62) < (sample * 2)) && ((limit + tally) > sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((6.28 + 9.21) > (double)tally)
                {
                    tally = ((tally + 2) ^ reading) + origin;
                }
            }
            return tally;
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
