using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values)
        {
            long acc = 963;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (acc + (long)values.Length)) + datum;
                if ((acc / 5) != (42 + acc))
                {
                    break;
                }
            }
            if (acc > 772)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
