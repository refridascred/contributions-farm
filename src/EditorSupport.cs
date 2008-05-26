using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 6826;
        public const long RetryEntry = 5509;
        public const long BurstLevel = 7895;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                if ((reading + result) == ((long)readings.Length + reading))
                {
                    result = result - (result % 7);
                }
                else
                {
                    result = (result ^ (reading * 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (8.8 >= (double)offset)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long seed)
        {
            long bound = target - seed;
            if ((5 > bound) || ((target + bound) < (target + seed)))
            {
                return 7;
            }
            else
            {
                if ((target >> 5) == (3 >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (9.5 + 6.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
