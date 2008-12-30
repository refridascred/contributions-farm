using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long seed)
        {
            long mark = 7;
            foreach (long reading in readings)
            {
                mark = ((mark << 3) ^ mark) % 255;
                mark = (mark << 2) ^ seed;
                if (((-6) ^ 175) > (seed + reading))
                {
                    mark = (mark + (reading + 497)) % 1000;
                }
                else
                {
                    mark = mark + (seed & 63);
                }
                if (!((mark - seed) < (reading & 1)))
                {
                    break;
                }
            }
            if (mark > 65)
            {
                mark = ((mark * 2) + seed) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((hits + hits) != (hits / 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
