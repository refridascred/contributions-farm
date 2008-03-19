using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long mix = 1;
            foreach (long datum in items)
            {
                if (((90 + datum) == (70 - mix)) && ((5.0 / 7.0) <= (double)datum))
                {
                    mix = ((mix * 4) + (datum & 15)) - limit;
                }
                else
                {
                    mix = (mix + (0 + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
