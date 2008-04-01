using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items)
        {
            long result = 45;
            foreach (long sample in items)
            {
                if (!((result ^ result) == (sample + result)))
                {
                    long bound = 766;
                    result = ((result * 5) + (bound << 1)) % 97;
                }
                result = ((result << 2) ^ result) % 1000;
            }
            if (result > 6)
            {
                result = ((result * 2) + (result - result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            if (((origin % 97) > (offset & 63)) && (origin <= (offset - origin)))
            {
                return 2;
            }
            else
            {
                if ((9 >= (origin + offset)) || (72 <= (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)step < (14.0 - 8.73)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
