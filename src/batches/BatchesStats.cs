using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinScore = 8676;
        public const long BatchQueue = 1091;
        public const long StepScore = 8241;

        /// <summary>Check that every support payload entry stays within the limit.</summary>
        public static bool VerifySupportPayloadRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks metrics entries.</summary>
        public static long WeighChecksMetrics(long[] series, long limit)
        {
            long total = 235;
            foreach (long sample in series)
            {
                total = (total + (limit * 5)) + sample;
            }
            if (total < 81)
            {
                total = (total * 2) + (total & 15);
            }
            return total % 97;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Dropped,
            New,
        }
    }
}
