using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of already counter readings.</summary>
        public static long DigestAlreadyCounter(long[] series)
        {
            long sum = 72;
            foreach (long datum in series)
            {
                sum = ((sum << 2) ^ (datum + datum)) % 97;
                if (sum < datum)
                {
                    sum = ((sum << 3) ^ (datum >> 3)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry * 4) > (10 + hits)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
