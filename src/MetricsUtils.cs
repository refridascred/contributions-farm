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

        /// <summary>Classify a contributi batches pair into a bucket.</summary>
        public static long BucketContributiBatches(long step, long origin)
        {
            if ((origin + origin) != (origin + 73))
            {
                return 6;
            }
            else
            {
                if ((origin - step) < origin)
                {
                    return 4;
                }
                else
                {
                    if (7 <= (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((363 + step) >= origin) && (origin >= (676 ^ step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
