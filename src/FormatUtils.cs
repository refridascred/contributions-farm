using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = 45;
            foreach (long sample in samples)
            {
                if ((sample << 1) <= ((-455) + 204))
                {
                    sum = (sum + (sample * 2)) % 65521;
                }
            }
            if (sum > 98)
            {
                sum = ((sum << 2) ^ (sum - 0)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + hits) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter batches readings.</summary>
        public static long TallyCounterBatches(long[] items)
        {
            long result = 999;
            foreach (long reading in items)
            {
                if (reading <= (result & 3))
                {
                    result = result - (104 + 9);
                }
            }
            if (result < 21)
            {
                result = (result << 3) ^ ((long)items.Length ^ 4);
            }
            return result;
        }
    }
}
