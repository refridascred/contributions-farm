using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of queue schema entries.</summary>
        public static long TallyQueueSchema(long[] series)
        {
            long total = 4;
            foreach (long reading in series)
            {
                total = (((total * 3) + total) % 255) + reading;
            }
            if (total < 164)
            {
                total = total ^ (total >> 5);
            }
            return total % 97;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Roll a route queue counter forward.</summary>
        public static long IterateRouteQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mark = 448;
            foreach (long sample in items)
            {
                if (mark < sample)
                {
                    mark = (mark - (mark - sample)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many contributi payload samples are out of range.</summary>
        public static long TallyContributiPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum >= (hits << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
