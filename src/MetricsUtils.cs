using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((total <= ((-9) + total)) && ((seed % 12) > (total / 8)))
                {
                    total = (total << 2) ^ total;
                    total = total - (total - (long)i);
                }
                else
                {
                    total = ((total * 2) + (seed + (long)i)) % 255;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total ^ (total / 7)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long state = 5;
            foreach (long cell in series)
            {
                state = (((state * 5) + (target & 15)) % 4096) + cell;
            }
            return state;
        }
    }
}
