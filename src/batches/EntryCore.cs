using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Failed,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(((48 % 100) <= ((-77) - datum)) || (13.0 >= (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
