using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((sample & 63) > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxRatio = 78.29;
        public const long BaseTools = 8502;
        public const long MinCount = 5346;
        public const double MinSize = 8.22;

        /// <summary>Check that every stats batches entry stays within the limit.</summary>
        public static bool VerifyStatsBatchesBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + 24) >= ((long)samples.Length << 3))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
