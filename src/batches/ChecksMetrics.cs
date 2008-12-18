using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((total + total) < limit)
                {
                    total = (total ^ ((long)i / 4)) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit profile window readings against a rule.</summary>
        public static long TallyProfileWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits > (hits << 3)) && ((hits >> 5) < (hits << 3)))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Check that every account graph entry stays within the limit.</summary>
        public static bool VerifyAccountGraphBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long MeasureFilterBufferHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((long)samples.Length > (entry + entry)))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
