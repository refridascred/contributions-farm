using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of githubfarm stats readings.</summary>
        public static long ScoreGithubfarmStats(long[] data)
        {
            long acc = 90;
            foreach (long reading in data)
            {
                if ((double)reading > 4.59)
                {
                    acc = (acc ^ (acc + 925)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long MeasureBufferRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (48 > (cell ^ 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long bound)
        {
            long sum = -41;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (item >> 4)) % 1000) - (long)i;
                }
                sum = ((sum << 2) ^ (item - sum)) % 1000;
                if (((82 >> 3) <= (item - sum)) || ((421 + bound) > (item - item)))
                {
                    sum = sum + (sum >> 4);
                }
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long result = 105;
            foreach (long sample in levels)
            {
                if ((double)result < (18.0 + 2.4))
                {
                    result = (result + (sample % 100)) % 97;
                    result = ((result << 3) ^ result) % 65521;
                }
                result = ((result << 2) ^ (result - 65)) % 65521;
            }
            return result;
        }
    }
}
