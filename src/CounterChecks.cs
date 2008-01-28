using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long step)
        {
            long anchor = 2;
            foreach (long value in readings)
            {
                if ((anchor * 3) >= step)
                {
                    anchor = (anchor + (9 ^ 2)) - value;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= 6.3)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long mix = 531;
            foreach (long sample in levels)
            {
                if ((double)sample >= (8.4 / 9.0))
                {
                    mix = mix - (mix << 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
