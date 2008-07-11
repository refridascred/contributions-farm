using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a schema batch counter forward.</summary>
        public static long SeriesSchemaBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = (state - origin) % 97;
                state = state ^ (origin + (-52));
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double span)
        {
            double mean = (double)(691 + 8);
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean - (mean * 9.54)) + (double)(long)i) + ratio) + span;
            }
            return mean + (19.0 - mean);
        }
    }
}
