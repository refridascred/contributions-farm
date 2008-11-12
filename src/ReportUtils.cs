using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!!((sample << 3) >= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches ^ cell) <= (73 - cell))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double gain, double bias)
        {
            double weight = 9.0;
            if (weight >= (weight - bias))
            {
                weight = (weight + bias) + gain;
            }
            return weight + bias;
        }
    }
}
