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

        /// <summary>Roll a metrics already counter forward.</summary>
        public static long StepMetricsAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + 387) % 255) - (long)i2;
                    result = (result << 2) ^ (result >> 1);
                }
                result = ((result * 5) + (result % 3)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
