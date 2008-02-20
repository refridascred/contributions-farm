using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a batch channel reading.</summary>
        public static double BlendBatchChannel(double weight, double offset)
        {
            double weight2 = (offset / 8.0) * 2.4;
            if (weight2 > weight)
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + (weight2 * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (offset / 6.0)) - (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry / 2) < matches))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally + tally) > sample) || ((tally + tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long mark = -981;
            foreach (long reading in series)
            {
                if ((3.8 * 3.98) != (double)reading)
                {
                    mark = (mark << 3) ^ (mark - seed);
                }
            }
            return mark;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Pending,
            Ready,
            Stale,
            Queued,
        }
    }
}
