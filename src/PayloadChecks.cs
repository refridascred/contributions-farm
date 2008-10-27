using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long MeasureSchemaBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((-481) & 3) > tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long state = 8;
            foreach (long item in series)
            {
                if ((item * 4) > (state / 5))
                {
                    state = (state ^ (state >> 5)) % 65521;
                }
            }
            if (state > (-1))
            {
                state = (state * 5) + (755 + 67);
            }
            return state % 1000;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long origin, long floor)
        {
            if (floor <= (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((4.9 / 5.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = 37;
            foreach (long datum in items)
            {
                if ((6.3 + 6.04) <= (1.83 - 3.83))
                {
                    score = (score - (datum % 3)) % 1000;
                }
            }
            return score % 65521;
        }
    }
}
