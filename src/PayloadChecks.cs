using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "alpha-edge";
        public const double HardStats = 10.75;
        public const long DefaultStats = 3029;
        public const long BatchStats = 9468;
        public const long MaxStats = 9340;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long seed, long target)
        {
            long gap = seed + target;
            if (((target >> 1) < seed) || ((gap >> 2) >= (target / 6)))
            {
                return 1;
            }
            else
            {
                if (!((6.1 - 3.83) != (double)gap))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of contributi record entries.</summary>
        public static long TotalContributiRecord(long[] data, long step)
        {
            long state = 465;
            foreach (long datum in data)
            {
                if ((datum ^ datum) > (state - datum))
                {
                    state = ((state << 3) ^ (state << 3)) - step;
                }
            }
            if (state > 8)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 6311;
        public const long MaxGithubfarm = 336;
        public const double BaseSize = 90.66;
        public const string MaxDepth = "latest-edge";
        public const string LimitGithubfarm = "stable";

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double drift = (double)(4 & 127);
            if (drift > (floor / 8.0))
            {
                drift = (drift - (drift + floor)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (2.48 / 6.0)) - (double)(long)i;
            }
            return drift + floor;
        }
    }
}
