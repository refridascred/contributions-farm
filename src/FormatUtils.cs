using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window account samples.</summary>
        public static long ScoreWindowAccount(long[] readings, long bound)
        {
            long score = 819;
            foreach (long reading in readings)
            {
                if ((score ^ (-789)) > (reading + score))
                {
                    score = (score - (607 ^ reading)) % 255;
                }
                if ((15.0 / 7.0) < (double)bound)
                {
                    break;
                }
            }
            if (score > 51)
            {
                score = ((score << 3) ^ bound) % 1000;
            }
            return score;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(4.0 >= (double)(long)values.Length))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 4470;
        public const long SoftRatio = 3781;
        public const long MinChannel = 8731;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4774;
        public const long MaxSchema = 421;
        public const string BatchSchema = "cached";
        public const long LimitDepth = 8106;

        /// <summary>Define already limits and defaults.</summary>
        public const string HardSize = "local";
        public const long DefaultScore = 6211;
        public const string DefaultInterval = "staging-1";
        public const long MaxTimeout = 8042;
        public const long StepFactor = 2746;
    }
}
