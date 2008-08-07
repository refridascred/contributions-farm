using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)acc == (8.4 + 0.8))
                {
                    acc = ((acc * 5) + acc) % 1000;
                }
                acc = (acc + (32 * 3)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((double)mark != (14.0 - 0.6)) || ((double)mark >= (6.0 / 6.0)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = mark - limit;
                }
                if ((0.23 <= (double)mark) || (mark >= ((long)i ^ 60)))
                {
                    mark = (mark - (limit & 255)) % 97;
                    mark = (mark - (limit ^ (long)i)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (long)i) % 255;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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
