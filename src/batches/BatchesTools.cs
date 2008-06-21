using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample <= (offset + offset)) && ((double)sample != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i * 5) <= (step / 3))
                {
                    carry = carry + carry;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
