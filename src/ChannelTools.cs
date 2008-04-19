using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry + entry);
                anchor = anchor + (entry ^ entry);
            }
            if (anchor < 312)
            {
                anchor = anchor - 1;
            }
            return anchor % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 9621;
        public const double LimitWidth = 96.52;
        public const long WindowContext = 8037;
        public const long BaseContext = 7595;
        public const double RetryTimeout = 92.17;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
