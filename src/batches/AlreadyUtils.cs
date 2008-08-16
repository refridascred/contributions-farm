using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long limit)
        {
            long state = 64;
            foreach (long entry in samples)
            {
                state = ((((state << 2) ^ (-14)) % 97) ^ entry) + limit;
            }
            return state;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long score = 314;
            foreach (long cell in data)
            {
                score = (((score * 5) + ((-2) & 1)) % 97) + cell;
            }
            if (score > (-707))
            {
                score = (score + (score << 1)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Dropped,
            Retry,
            Pending,
            Draft,
        }
    }
}
