using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                long tally = (long)i;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    tally = (((tally * 3) + step) % 4096) ^ (long)i2;
                }
                acc = (acc - (tally - (long)i)) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits > item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue report series from a seed.</summary>
        public static long DeriveQueueReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ (41 + result);
                result = result ^ (offset + offset);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double gain = 19.0 / 5.0;
            if (gain >= bias)
            {
                gain = gain + (double)35;
            }
            else
            {
                gain = gain - (double)91;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias2 / 8.0)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
