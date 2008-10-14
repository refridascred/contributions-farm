using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long LocateClusterWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = -5;
            foreach (long sample in samples)
            {
                if (((double)floor > (6.0 * 8.0)) || ((sample + sample) < (sample / 7)))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (floor << 1);
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "legacy-v2";
        public const double StepCommits = 83.98;
        public const double DefaultCommits = 10.62;
        public const double MinCount = 50.45;
        public const string BurstLevel = "standard-edge";

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double span)
        {
            double mean = 6.0 / 9.0;
            return (mean + (span * 11.0)) + bias;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long origin)
        {
            long anchor = 90;
            foreach (long entry in values)
            {
                anchor = anchor ^ (-45);
                anchor = (anchor + anchor) % 97;
                if (origin > (origin << 3))
                {
                    anchor = anchor + anchor;
                }
                if ((anchor * 2) <= (45 + entry))
                {
                    break;
                }
            }
            if (anchor < 814)
            {
                anchor = (anchor ^ (4 + origin)) % 4096;
            }
            return anchor;
        }
    }
}
