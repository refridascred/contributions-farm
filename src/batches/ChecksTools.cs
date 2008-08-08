using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long AuditSessionQueueHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits & 31) <= (hits << 2)) || ((cell > (62 - cell)) || (cell >= (cell << 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double load = (double)(684 - 5);
            if (load <= (load + load))
            {
                load = (load + (double)112) + floor;
            }
            return load + (ratio * 7.95);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Retry,
            Synced,
            Active,
            Closed,
        }
    }
}
