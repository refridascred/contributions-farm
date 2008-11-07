using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ (step & 31);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (seed > (tally + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a filter record reading by value.</summary>
        public static long FindFilterRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
