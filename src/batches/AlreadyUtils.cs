using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 2) > ((-4) / 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series, long limit)
        {
            long total = 8;
            foreach (long reading in series)
            {
                if (limit > (total / 2))
                {
                    total = ((total << 2) ^ total) ^ reading;
                }
                if ((4 - limit) < (873 >> 2))
                {
                    break;
                }
            }
            if (total > 661)
            {
                total = (total * 2) + (limit / 8);
            }
            return total;
        }

        /// <summary>Classify a contributi notes pair into a bucket.</summary>
        public static long BucketContributiNotes(long target, long limit)
        {
            if (limit <= (limit * 3))
            {
                return 3;
            }
            else
            {
                if ((target >> 3) >= (limit - 53))
                {
                    return 8;
                }
                else
                {
                    if ((double)target > (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit % 16) <= (target / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double drift = (double)27 / 4.0;
            if (drift >= 1.78)
            {
                drift = drift + (ratio + 18.0);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (double)25;
        }
    }
}
