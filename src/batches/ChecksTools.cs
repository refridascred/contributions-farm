using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long score = 95;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) <= (468 + 9))
                {
                    score = (score - (69 & 3)) % 101;
                }
            }
            if (score > 70)
            {
                score = ((score * 2) + (score & 15)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                carry = carry - (4 >> 5);
                if ((carry <= (entry << 3)) || (5.89 < (double)carry))
                {
                    carry = carry + (carry + entry);
                }
            }
            return carry;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 2) ^ (acc - acc)) % 101) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate counter format readings against a bound.</summary>
        public static bool GuardCounterFormatBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
