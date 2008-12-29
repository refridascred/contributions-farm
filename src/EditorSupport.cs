using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route record entries.</summary>
        public static long WeighRouteRecord(long[] series, long floor)
        {
            long sum = -57;
            foreach (long reading in series)
            {
                if (!((6 * 4) == (12 - reading)))
                {
                    sum = (((sum << 2) ^ (-704)) % 255) + floor;
                }
                else
                {
                    sum = ((sum * 5) + (reading * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 3097;
        public const long HardEntry = 2370;
        public const long StepEntry = 9437;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            New,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(((double)count < 7.0) && ((count + datum) >= (datum & 127))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
