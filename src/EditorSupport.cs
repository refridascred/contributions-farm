using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every contributi command entry stays within the limit.</summary>
        public static bool CheckContributiCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a context checks sample.</summary>
        public static long LocateContextChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long origin)
        {
            long score = 35;
            foreach (long sample in readings)
            {
                if ((3.4 + 7.87) < (double)origin)
                {
                    score = (((score << 3) ^ score) % 65521) + sample;
                }
                else
                {
                    score = ((score << 2) ^ score) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((offset - 268) < ((long)data.Length + tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "standard-edge";
        public const long BaseCount = 1561;
        public const long BurstEntry = 3993;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Draft,
            Failed,
            Idle,
        }
    }
}
