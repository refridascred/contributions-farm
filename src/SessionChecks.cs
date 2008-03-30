using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9.81 * 0.7) < (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((limit - hits) >= (3 ^ hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long result = 25;
            foreach (long item in samples)
            {
                if (seed >= (708 - seed))
                {
                    result = (result + seed) % 101;
                    break;
                }
                else
                {
                    result = (result ^ item) % 255;
                }
                if ((double)result <= (5.1 / 9.0))
                {
                    result = result - (item + seed);
                }
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ (bound / 9)) ^ (long)i2;
                }
                result = result + (bound >> 2);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
