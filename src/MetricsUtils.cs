using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long DeriveChannelChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + (-44)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((double)acc == (double)limit) || ((8.5 - 0.1) != (double)acc))
                {
                    acc = (acc - (limit ^ 6)) % 255;
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i + acc)) % 65521;
                }
                if (!((long)i == (acc + limit)))
                {
                    acc = (acc ^ (limit + acc)) % 255;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc + limit) % 65521) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Queued,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = ((anchor - (anchor * 2)) % 65521) + sample;
            }
            return anchor;
        }
    }
}
