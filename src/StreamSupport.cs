using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi token entries.</summary>
        public static long ScoreContributiToken(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = (mix - (value - value)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the command batch entries that pass the check.</summary>
        public static long AuditCommandBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample & 3) <= (sample / 3)) && ((758 << 2) <= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Done,
            Failed,
            Draft,
            Active,
        }
    }
}
