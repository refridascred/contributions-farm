using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank report account input into a small class.</summary>
        public static long BucketReportAccount(long step, long offset)
        {
            if ((step - step) >= (step + offset))
            {
                return 6;
            }
            else
            {
                if ((step / 7) <= (step ^ offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset <= (7.2 * 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long TallySessionMetricOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((limit * 4) == (matches + (long)samples.Length))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long mix = 267;
            foreach (long cell in samples)
            {
                if ((long)samples.Length > ((long)samples.Length + mix))
                {
                    mix = (mix ^ 795) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
