using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = ratio + (double)98;
            }
            else
            {
                ratio = ratio + (ratio / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (double)63;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8267;
        public const string HardTools = "standard-v2";
        public const double StepTimeout = 87.36;
        public const long SoftSize = 6894;

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6281;
        public const string BaseLevel = "alpha-v2";
        public const long BurstLevel = 8778;
        public const double DefaultWidth = 84.36;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Closed,
            Stale,
            Done,
            New,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
