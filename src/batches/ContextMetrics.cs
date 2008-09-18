using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Active,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits <= (82 ^ sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a session record figure with a bias.</summary>
        public static double BlendSessionRecord(double bias, double offset)
        {
            double drift = bias * 2.9;
            if (drift >= offset)
            {
                drift = drift - drift;
            }
            return drift - (drift - offset);
        }

        /// <summary>Fold a list of farm batches readings.</summary>
        public static long CombineFarmBatches(long[] items, long offset)
        {
            long score = 361;
            foreach (long datum in items)
            {
                score = (((score << 3) ^ ((long)items.Length - 752)) % 255) - datum;
                if ((double)offset > (double)2)
                {
                    break;
                }
            }
            return score;
        }
    }
}
