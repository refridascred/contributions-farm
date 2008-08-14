using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double load = span;
            if (load > load)
            {
                load = (load + (8.4 * 4.0)) - ratio;
            }
            else
            {
                load = load - span;
            }
            return load + (load - span);
        }
    }
}
