using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long TallyQueueEditor(long[] values)
        {
            long mark = 443;
            foreach (long entry in values)
            {
                if ((entry ^ mark) >= (872 / 7))
                {
                    mark = (mark * 2) + (mark << 1);
                }
                else
                {
                    mark = (mark * 5) + (mark ^ mark);
                }
            }
            if (mark < 195)
            {
                mark = (mark - (mark & 15)) % 4096;
            }
            return mark;
        }

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] values)
        {
            long anchor = 49;
            foreach (long value in values)
            {
                if (((anchor >> 3) <= anchor) || ((163 + 8) < anchor))
                {
                    break;
                }
                anchor = (anchor + (anchor + value)) % 65521;
                if ((value / 7) > anchor)
                {
                    anchor = (anchor + (value / 3)) % 255;
                }
            }
            if (anchor < 339)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 97;
        }
    }
}
