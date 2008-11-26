using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 872;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ (322 >> 1)) + cell;
            }
            if (result < 90)
            {
                result = (result * 5) + (result ^ result);
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ (result % 60);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((0.86 * 8.11) >= (double)(long)i)
                {
                    total = total - 367;
                    total = total ^ step;
                }
                total = total - (total + step);
                total = ((total << 3) ^ (step + 256)) % 101;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
