using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long CountAlreadyFilterMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((50 + matches) > (matches << 1)) && ((-68) > (long)levels.Length)) || (((4.67 * 9.27) <= (double)value) || ((target + value) < value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
