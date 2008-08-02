using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a payload command pair into a bucket.</summary>
        public static long GradePayloadCommand(long origin, long limit)
        {
            long lane = origin + limit;
            if ((lane >> 3) >= (limit << 1))
            {
                return 8;
            }
            else
            {
                if (!((17 >> 5) == (801 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 79;
            foreach (long reading in readings)
            {
                total = total + total;
                total = (total + (reading - 68)) % 1000;
                if ((17.0 - 5.01) != (double)total)
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 65521;
        }
    }
}
