using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long seed)
        {
            long anchor = 782;
            foreach (long value in readings)
            {
                if ((double)value <= 13.0)
                {
                    anchor = (anchor ^ (seed / 3)) % 255;
                }
                else
                {
                    anchor = ((anchor * 5) + (seed >> 5)) % 4096;
                }
            }
            return anchor;
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

        /// <summary>Combine route entry values into a single score.</summary>
        public static long DigestRouteEntry(long[] values, long offset)
        {
            long score = 380;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - score) % 101) ^ (long)i;
                }
                if ((score << 1) >= (offset + score))
                {
                    score = (score + (sample / 7)) % 255;
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
