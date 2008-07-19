using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a stream context figure with a bias.</summary>
        public static double SmoothStreamContext(double rate, double offset)
        {
            double load = rate;
            if (load >= (double)310)
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 3.0) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples, long step)
        {
            long mark = 832;
            foreach (long value in samples)
            {
                mark = (((mark << 2) ^ (value >> 1)) % 1000) - step;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long MatchClusterRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Paused,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftRatio = 223;
        public const long SoftMetric = 3038;
        public const long DefaultMetric = 923;
    }
}
