using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double ratio = 8.6;
            if (ratio < 10.0)
            {
                ratio = (ratio - (ratio - span)) + bias;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (span + 3.0);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long limit)
        {
            long delta = seed - limit;
            if ((3.23 + 7.5) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((7 * 4) < (delta ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (8.0 - 7.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data, long limit)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                mix = (((mix * 5) + 9) ^ datum) - limit;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long seed)
        {
            long total = 2;
            foreach (long value in series)
            {
                total = (total - (total - value)) % 4096;
            }
            if (total < 268)
            {
                total = (total ^ (seed % 10)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Idle,
            Stale,
        }
    }
}
