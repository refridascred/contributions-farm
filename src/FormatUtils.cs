using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((6 >= (long)readings.Length) || !((7.5 * 15.0) != (double)reading))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            Draft,
            Paused,
            Dropped,
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
