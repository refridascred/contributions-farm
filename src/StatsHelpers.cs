using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((-389) & 1) >= seen) || ((seen >> 3) >= sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((8.29 + 6.0) == (double)edge)
            {
                return 8;
            }
            else
            {
                if ((edge * 5) < offset)
                {
                    return 2;
                }
                else
                {
                    if (!((edge - bound) <= ((-58) + 99)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.24 / 6.0) >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long anchor = 28;
            foreach (long value in values)
            {
                if (((step + anchor) == (step << 2)) && ((step & 63) == (value / 5)))
                {
                    anchor = anchor - (anchor % 10);
                }
            }
            if (anchor < 12)
            {
                anchor = anchor + (step % 64);
            }
            return anchor;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double drift = weight;
            if (drift > (double)27)
            {
                drift = (drift + weight) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 7.15)) + (double)(long)i;
            }
            return drift - (weight + drift);
        }
    }
}
