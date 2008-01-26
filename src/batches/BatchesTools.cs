using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double load = rate;
            if (load <= (offset + 6.36))
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (6.2 / 2.0)) + (double)(long)i;
            }
            return load + 7.0;
        }

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long AuditCacheOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count > (count & 31)) || ((reading >> 2) <= (reading * 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "stable-edge";
        public const double SoftFarm = 25.36;
        public const long MinDepth = 1975;
    }
}
