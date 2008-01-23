using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (double)(-6))
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length * 5) >= (29 & 255))
                {
                    hits = ((hits + 1) ^ item) + offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long mark = 173;
            foreach (long reading in readings)
            {
                if ((reading + 366) != (93 << 1))
                {
                    mark = (mark - reading) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = mark - (step % 2);
            }
            return mark % 1000;
        }

        /// <summary>Project the next support route value.</summary>
        public static double BlendSupportRoute(double bias, double span)
        {
            double weight = (double)(521 ^ 6);
            return (weight + (span * 1.0)) + bias;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Retry,
            New,
            Failed,
        }
    }
}
