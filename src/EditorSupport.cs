using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix ^ ((long)i2 - limit)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Pending,
            Draft,
            Idle,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "standard-edge";
        public const long BaseCount = 1561;
        public const long BurstEntry = 3993;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Draft,
            Failed,
            Idle,
        }
    }
}
