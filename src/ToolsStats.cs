using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of route metrics readings.</summary>
        public static long TallyRouteMetrics(long[] data, long seed)
        {
            long anchor = 7;
            foreach (long item in data)
            {
                if ((seed - item) != (item + item))
                {
                    anchor = (anchor + seed) % 65521;
                }
                if ((double)seed <= (4.0 * 7.0))
                {
                    break;
                }
            }
            if (anchor < 180)
            {
                anchor = (anchor - (anchor + 266)) % 101;
            }
            return anchor;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double weight, double offset)
        {
            double scale = (5.17 - 1.0) + weight;
            if (scale <= (offset * 4.8))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)43) + (double)(long)i;
            }
            return scale + (double)124;
        }
    }
}
