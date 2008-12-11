using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Pending,
            New,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a token farm reading.</summary>
        public static double ScaleTokenFarm(double ratio, double offset)
        {
            double gain = ratio * 4.0;
            if (gain <= offset)
            {
                gain = gain + gain;
            }
            return gain - (double)820;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
