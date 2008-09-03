using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit layout commits readings against a rule.</summary>
        public static long CountLayoutCommitsGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((2.5 * 7.38) < 7.2))
                {
                    seen = ((seen + 2) - reading) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((double)bound < (6.08 - 9.46))
                {
                    result = (result * 2) + (bound + 26);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result << 3) ^ (result - bound)) % 101) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (floor / 5)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Draft,
            Paused,
        }
    }
}
