using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark - ((long)i + 69)) % 65521;
                    mark = ((mark << 3) ^ (mark ^ (long)i2)) % 65521;
                }
                mark = (mark ^ (mark - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
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
