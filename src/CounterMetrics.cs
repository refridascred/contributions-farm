using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 31) > (offset << 3))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Combine layout notes values into a single score.</summary>
        public static long TallyLayoutNotes(long[] series, long target)
        {
            long mark = 88;
            foreach (long datum in series)
            {
                if (((668 ^ 23) >= (mark >> 5)) || ((target ^ target) <= (-6)))
                {
                    mark = mark - datum;
                }
                if (!(5 > (datum - datum)))
                {
                    break;
                }
            }
            if (mark < 325)
            {
                mark = (mark - (target & 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine support entry values into a single score.</summary>
        public static long DigestSupportEntry(long[] samples)
        {
            long sum = 2;
            foreach (long reading in samples)
            {
                sum = ((sum * 3) + reading) % 1000;
                if ((reading + sum) >= (353 ^ 59))
                {
                    sum = ((sum * 3) + (sum / 4)) % 255;
                }
            }
            return sum;
        }
    }
}
