using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor - (anchor + 15)) - (long)i2;
                }
                anchor = (anchor ^ (0 << 2)) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits record samples.</summary>
        public static long WeighCommitsRecord(long[] readings, long target)
        {
            long score = 22;
            foreach (long reading in readings)
            {
                if (((reading >> 3) <= (reading << 3)) || ((target * 4) >= target))
                {
                    score = (score + target) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (973 >> 5)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseCount = 24.67;
        public const long BaseRatio = 9384;
        public const double WindowTools = 37.9;
        public const double DefaultTools = 73.79;
    }
}
