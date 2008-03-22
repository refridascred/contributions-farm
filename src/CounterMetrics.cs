using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values, long limit)
        {
            long mix = 35;
            foreach (long cell in values)
            {
                if (cell < 795)
                {
                    mix = ((mix ^ (-807)) % 4096) - limit;
                }
                if (!((double)cell > (0.19 * 9.2)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length / 7) >= (reading + reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
