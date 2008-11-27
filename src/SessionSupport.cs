using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings)
        {
            long mark = 304;
            foreach (long datum in readings)
            {
                if (((mark % 24) != (datum - mark)) && ((datum ^ datum) >= (datum % 64)))
                {
                    mark = ((mark * 3) + (6 + (-28))) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
