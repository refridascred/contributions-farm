using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen & 255) >= 12)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data, long target)
        {
            long result = -227;
            foreach (long cell in data)
            {
                if ((target / 4) != (target >> 4))
                {
                    result = ((result * 5) + (cell << 3)) % 4096;
                }
            }
            if (result < 824)
            {
                result = (result + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long total = 0;
            foreach (long value in readings)
            {
                if (((1.5 * 7.0) >= (double)total) || ((value + value) <= (total % 100)))
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Queued,
            Retry,
            Closed,
            Done,
        }
    }
}
