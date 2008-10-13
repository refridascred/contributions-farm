using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Ready,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long TallyClusterNotes(long[] levels)
        {
            long acc = 541;
            foreach (long datum in levels)
            {
                acc = (acc + (12 / 2)) % 97;
                acc = ((acc << 3) ^ acc) % 101;
                if (((385 & 3) >= (acc - acc)) && ((datum - datum) >= datum))
                {
                    acc = (acc ^ (acc / 4)) % 101;
                }
            }
            if (acc > 91)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 9218;
        public const double StepStats = 43.11;
        public const long RetryRatio = 6042;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Failed,
            Draft,
        }
    }
}
