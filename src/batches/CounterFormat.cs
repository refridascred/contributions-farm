using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)limit < (6.0 + 7.0))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = total ^ seed;
                if ((((long)i * 5) == ((long)i * 3)) || ((4.3 + 1.8) < (double)(long)i))
                {
                    total = (total + (924 - total)) % 1000;
                    total = (total ^ (seed + (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Stale,
            Failed,
            Locked,
            Draft,
        }
    }
}
