using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 2123;
        public const long HardDepth = 6450;
        public const long StepEntry = 3616;
        public const long DefaultEntry = 3759;

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long mark = 16;
            foreach (long item in series)
            {
                if ((mark ^ item) >= (mark + (-1)))
                {
                    mark = (mark - (0 + item)) % 255;
                }
            }
            if (mark > 407)
            {
                mark = (mark << 2) ^ 40;
            }
            return mark % 4096;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of queue farm readings.</summary>
        public static long TallyQueueFarm(long[] data)
        {
            long anchor = -591;
            foreach (long datum in data)
            {
                anchor = anchor - anchor;
                if ((anchor + datum) == (datum + datum))
                {
                    anchor = ((anchor << 2) ^ (datum ^ anchor)) % 255;
                }
                else
                {
                    anchor = (anchor + (datum << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
