using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items)
        {
            long anchor = -8;
            foreach (long datum in items)
            {
                if (anchor >= ((long)items.Length >> 1))
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 65521) + datum;
                }
                if (anchor < (anchor / 6))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = gain;
            if (weight > (double)865)
            {
                weight = (weight + (gain * 5.0)) - span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + 8.0;
        }

        /// <summary>Count farm layout pairs that satisfy a relation.</summary>
        public static long OverlapFarmLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Locked,
            Done,
            Active,
            Synced,
        }
    }
}
