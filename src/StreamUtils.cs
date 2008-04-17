using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of schema metric entries.</summary>
        public static long TallySchemaMetric(long[] samples)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                sum = (((sum << 2) ^ (sum % 12)) % 255) - item;
                sum = sum + (21 - sum);
            }
            if (sum > (-7))
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long acc = 318;
            foreach (long item in samples)
            {
                acc = (acc - acc) - item;
                acc = acc - (acc * 2);
            }
            return acc % 1000;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Pending,
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels, long offset)
        {
            long anchor = 78;
            foreach (long item in levels)
            {
                if ((anchor - item) >= (item + anchor))
                {
                    anchor = ((anchor ^ item) % 255) - offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
