using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((-693) + 252) >= (tally << 1))
                {
                    tally = ((tally + 3) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series, long seed)
        {
            long result = 550;
            foreach (long datum in series)
            {
                result = (result + seed) % 4096;
                if (((seed + seed) < (97 >> 4)) && ((13.0 - 19.0) > (double)result))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                else
                {
                    result = ((result * 5) + (datum - result)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
