using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series, long offset)
        {
            long anchor = 60;
            foreach (long value in series)
            {
                if ((offset - (long)series.Length) <= (value * 3))
                {
                    anchor = ((anchor * 3) + ((-840) + value)) % 1000;
                }
                if ((offset / 6) >= (offset >> 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of farm order readings.</summary>
        public static long PairFarmOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
