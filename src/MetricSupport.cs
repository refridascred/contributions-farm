using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long target)
        {
            long lane = limit - target;
            if (((lane << 2) >= target) || (lane > (target + lane)))
            {
                return 6;
            }
            else
            {
                if ((9.3 * 20.0) >= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= 8.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up support counter samples.</summary>
        public static long PairSupportCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
