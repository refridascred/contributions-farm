using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 1209;
        public const double StepReport = 72.75;
        public const long BaseReport = 7643;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long anchor = -560;
            foreach (long item in samples)
            {
                anchor = (anchor - (bound << 1)) % 4096;
                if ((9.41 / 5.0) != (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor + item)) % 101;
                    anchor = anchor ^ (anchor & 3);
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                    anchor = (anchor + (item ^ bound)) % 101;
                }
                if (!((double)bound != (double)anchor))
                {
                    anchor = (anchor + (anchor << 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long TallyTokenChannelOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (tally + tally))
                {
                    tally = ((tally + 3) + datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
