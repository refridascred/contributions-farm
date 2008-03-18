using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((16.0 + 3.27) != (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a order layout reading by value.</summary>
        public static long SeekOrderLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits >= (value & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics record series from a seed.</summary>
        public static long StepMetricsRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Done,
            Paused,
        }
    }
}
