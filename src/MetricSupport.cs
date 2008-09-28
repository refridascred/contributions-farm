using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples)
        {
            long sum = 161;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum * 3) + (reading & 15)) % 97) ^ (long)i;
                    sum = sum ^ (reading / 3);
                }
                sum = (sum ^ (reading - (-72))) % 255;
                sum = (sum + 795) % 4096;
                if (7 < (reading ^ reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Locked,
            Failed,
            New,
            Done,
        }
    }
}
