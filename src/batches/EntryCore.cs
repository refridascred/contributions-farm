using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate payload graph samples.</summary>
        public static long CombinePayloadGraph(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                mix = (mix ^ (9 + sample)) % 97;
                if ((mix << 1) <= (mix / 5))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series, long step)
        {
            long sum = 78;
            foreach (long reading in series)
            {
                sum = sum + (reading + step);
                sum = ((sum * 5) + (step - sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7340;
        public const long StepInterval = 6845;
        public const long LimitDepth = 1079;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if ((0 ^ anchor) > (anchor * 4))
                {
                    anchor = (anchor ^ 5) ^ item;
                }
            }
            return anchor;
        }
    }
}
