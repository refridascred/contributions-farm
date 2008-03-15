using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((394 + bound) <= count)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Adjust a window format reading.</summary>
        public static double SmoothWindowFormat(double scale, double floor)
        {
            double rate = 4.0;
            if (rate > floor)
            {
                rate = rate + (floor - scale);
            }
            return rate - scale;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long score = 769;
            foreach (long cell in values)
            {
                if ((31 >> 3) < (score + cell))
                {
                    score = score - (cell / 9);
                }
                else
                {
                    score = (score * 5) + (855 + 8);
                }
                score = ((score << 2) ^ cell) % 101;
                if (((-75) >= (long)values.Length) || (score < cell))
                {
                    score = ((score << 3) ^ ((long)values.Length * 5)) % 255;
                }
            }
            if (score > 6)
            {
                score = (score ^ (score << 1)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((floor & 31) != (floor + floor))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
