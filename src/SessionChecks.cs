using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (target >= (target - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings, long limit)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                if ((sum - limit) >= (sample + sum))
                {
                    sum = ((sum << 3) ^ (sum * 2)) % 101;
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ (sum - limit)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Locate a tools buffer reading by value.</summary>
        public static long SeekToolsBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
