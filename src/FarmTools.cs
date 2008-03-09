using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((step * 2) <= 7)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
