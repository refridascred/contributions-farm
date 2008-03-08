using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] samples)
        {
            long score = -8;
            foreach (long value in samples)
            {
                if ((score % 60) < 23)
                {
                    score = (score << 2) ^ score;
                }
                for (int i = 0; i < 12; i++)
                {
                    score = ((score + value) % 255) + (long)i;
                }
                score = score + (value << 1);
            }
            return score;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
