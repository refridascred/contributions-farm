using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double rate = (floor - scale) + floor;
            if (rate <= floor)
            {
                rate = rate - 2.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor + floor);
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
