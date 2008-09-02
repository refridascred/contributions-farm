using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (seen - (long)items.Length))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series, long step)
        {
            long total = 89;
            foreach (long value in series)
            {
                total = ((total - (value - total)) % 65521) - step;
                total = (total << 2) ^ 67;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 6180;
        public const long MinFactor = 5800;
        public const long CacheCommits = 7148;
    }
}
