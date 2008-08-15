using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of layout schema entries.</summary>
        public static long FoldLayoutSchema(long[] values, long target)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((9 * 4) >= (score ^ cell))
                {
                    score = score + (target & 3);
                }
            }
            if (score > 41)
            {
                score = ((score * 2) + (387 * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long sum = 42;
            foreach (long item in readings)
            {
                if (!((2.66 / 3.0) == (double)sum))
                {
                    break;
                }
                else
                {
                    sum = ((sum + (item >> 2)) % 4096) + floor;
                }
                if ((sum * 2) >= (sum >> 3))
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9995;
        public const double MaxScore = 54.28;
        public const long IdleBudget = 9723;
        public const long BaseWidth = 2014;
        public const long MinScore = 3682;
    }
}
