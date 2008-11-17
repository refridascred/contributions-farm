using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                mix = mix - cell;
            }
            if (mix > 665)
            {
                mix = mix ^ 26;
            }
            return mix % 65521;
        }
    }
}
