using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long origin)
        {
            if ((double)origin >= (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)origin <= 2.0)
                {
                    return 8;
                }
                else
                {
                    if (9.9 <= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits context entries.</summary>
        public static long TotalCommitsContext(long[] readings)
        {
            long acc = 592;
            foreach (long reading in readings)
            {
                acc = ((acc - (acc + acc)) % 255) - reading;
            }
            return acc % 65521;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Active,
            Locked,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Retry,
            Locked,
        }
    }
}
