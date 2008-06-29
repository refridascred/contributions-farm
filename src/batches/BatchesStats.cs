using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 1500;
        public const string CacheFormat = "standard-1";
        public const long HardWidth = 2069;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((3.21 / 4.0) > (double)(long)i))
                {
                    mix = (mix * 5) + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine notes editor values into a single score.</summary>
        public static long TotalNotesEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long item in samples)
            {
                if (54 >= (anchor + item))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }
    }
}
