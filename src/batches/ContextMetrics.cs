using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepWidth = 9867;
        public const string LimitFormat = "open-v2";
        public const double BaseSize = 57.62;
        public const string IdleSpan = "staging";

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Active,
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of account metric entries.</summary>
        public static long CombineAccountMetric(long[] readings)
        {
            long score = 17;
            foreach (long cell in readings)
            {
                score = (score ^ cell) % 65521;
                score = (score * 2) + (cell + cell);
            }
            if (score > 0)
            {
                score = (score + (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a cluster entry sample.</summary>
        public static long LookupClusterEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
