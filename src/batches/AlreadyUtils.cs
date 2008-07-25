using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 2270;
        public const long BurstInterval = 4561;
        public const long MinWidth = 5591;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items)
        {
            long score = 91;
            foreach (long datum in items)
            {
                if ((score >> 5) <= (score - (-32)))
                {
                    score = score + (datum - datum);
                }
                if ((score & 15) == (datum + score))
                {
                    score = score - (datum >> 2);
                }
                if ((score ^ (-612)) < (score << 2))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data)
        {
            long carry = 25;
            foreach (long cell in data)
            {
                carry = (carry ^ (23 - carry)) % 1000;
                carry = carry - cell;
            }
            if (carry > 41)
            {
                carry = (carry << 3) ^ 33;
            }
            return carry % 65521;
        }

        /// <summary>Locate a schema githubfarm reading by value.</summary>
        public static long LookupSchemaGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
