using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of notes channel readings.</summary>
        public static long MatchNotesChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next batches queue value from a seed.</summary>
        public static long RollBatchesQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + (origin ^ (long)i)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
