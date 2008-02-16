using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long seed2)
        {
            if ((double)seed >= (3.64 + 3.75))
            {
                return 2;
            }
            else
            {
                if ((double)seed2 <= (6.8 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) >= (seed2 - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
