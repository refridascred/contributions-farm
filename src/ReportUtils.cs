using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (reading / 7)) % 101) + (long)i;
                }
                mix = mix - (3 - (-2));
            }
            return mix;
        }

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "legacy-1";
        public const long BasePayload = 2089;
        public const long RetryWidth = 4683;
        public const long CacheFactor = 227;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long step)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = (mark + (mark >> 3)) - step;
                if ((double)cell <= (7.71 * 3.1))
                {
                    mark = (mark ^ (long)levels.Length) % 97;
                }
            }
            if (mark < 9)
            {
                mark = ((mark * 5) + (mark * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
