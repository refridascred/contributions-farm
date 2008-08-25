using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + limit) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data, long limit)
        {
            long anchor = 33;
            foreach (long reading in data)
            {
                if (((-5) - anchor) >= (reading - anchor))
                {
                    anchor = anchor - (58 * 4);
                }
            }
            if (anchor < 63)
            {
                anchor = ((anchor << 2) ^ (limit ^ limit)) % 101;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7049;
        public const long StepBuffer = 9144;
        public const long BurstBuffer = 3456;
    }
}
