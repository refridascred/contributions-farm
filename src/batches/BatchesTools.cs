using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count <= (count * 3)) && ((count << 2) < ((long)samples.Length - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
