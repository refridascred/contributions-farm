using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long origin)
        {
            long result = 2;
            foreach (long sample in values)
            {
                if (((65 >> 3) <= (result + origin)) && (origin < (origin * 5)))
                {
                    result = (result ^ (7 + sample)) % 255;
                }
            }
            return result;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (539 >= floor)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mix = -9;
            foreach (long reading in values)
            {
                if ((mix ^ reading) < (reading << 2))
                {
                    mix = (mix + reading) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
