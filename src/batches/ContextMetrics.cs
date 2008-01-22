using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((total % 2) <= (item << 2))
                {
                    total = (total + (item - total)) % 255;
                }
                else
                {
                    total = (total - (item & 3)) % 97;
                }
            }
            if (total < 5)
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total % 1000;
        }

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
