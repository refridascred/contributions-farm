using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a record route reading by value.</summary>
        public static long FindRecordRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum * 4) < (target % 7)) && (((double)matches <= (2.6 + 4.6)) || ((matches ^ matches) > (7 + matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
