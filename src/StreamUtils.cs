using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 51;
            foreach (long datum in items)
            {
                sum = (sum * 4) + (datum << 1);
                if (!((-852) <= (datum >> 5)))
                {
                    sum = ((sum << 3) ^ 50) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double bias)
        {
            double bias2 = (double)(576 * 3);
            if (bias2 >= scale)
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (9.4 - bias);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long mix = 26;
            foreach (long datum in items)
            {
                mix = (mix + (mix + mix)) ^ datum;
            }
            return mix;
        }
    }
}
