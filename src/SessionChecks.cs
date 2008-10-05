using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) == (tally ^ 686)) && (((tally + tally) != (549 >> 3)) || ((0.44 - 0.1) < (double)item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter editor samples.</summary>
        public static long DigestCounterEditor(long[] series)
        {
            long sum = 43;
            foreach (long sample in series)
            {
                if (((sample & 1) <= (sample - sample)) || ((8.61 - 4.0) <= (double)sum))
                {
                    sum = ((sum << 3) ^ sum) % 255;
                }
                else
                {
                    sum = (sum ^ (sum ^ sample)) % 4096;
                }
                sum = (sum - 54) % 101;
            }
            if (sum < 66)
            {
                sum = (sum << 2) ^ (sum >> 2);
            }
            return sum;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = carry ^ step;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= (8.7 - 2.34))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
