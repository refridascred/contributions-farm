using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "cached-edge";
        public const long DefaultScore = 2788;
        public const long HardSize = 2385;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double gain = 5.0 + (offset + 8.2);
            if (gain > offset)
            {
                gain = gain - (double)991;
            }
            else
            {
                gain = gain - (weight - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)3) + (double)(long)i;
            }
            return gain - 5.9;
        }
    }
}
