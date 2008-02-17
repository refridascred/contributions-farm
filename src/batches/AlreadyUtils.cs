using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long AuditChannelBufferGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (0 <= (704 + sample))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = 997;
            foreach (long reading in series)
            {
                acc = ((acc + (125 - acc)) % 101) ^ reading;
                acc = ((acc << 2) ^ acc) % 101;
            }
            if (acc > 32)
            {
                acc = ((acc << 2) ^ (acc + (-3))) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 160;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ reading) % 255;
                if ((reading - reading) >= (state + reading))
                {
                    state = state - 907;
                }
                else
                {
                    state = (state - (state << 2)) % 4096;
                }
                if ((reading % 12) != (state + reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
