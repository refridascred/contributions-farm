using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every notes metrics entry stays within the limit.</summary>
        public static bool VerifyNotesMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings, long target)
        {
            long score = 590;
            foreach (long item in readings)
            {
                if (((0 + item) == (score << 2)) || ((4.64 * 3.0) > (double)score))
                {
                    score = ((score + score) % 101) + target;
                }
            }
            return score;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
