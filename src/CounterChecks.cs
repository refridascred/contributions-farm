using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first token order entry that matches the target.</summary>
        public static long LookupTokenOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a stream window pair into a bucket.</summary>
        public static long GradeStreamWindow(long bound, long seed)
        {
            if ((12.0 + 8.2) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((seed + seed) < (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if (bound > (bound + 491))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound & 63) < seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long limit)
        {
            long sum = -1;
            foreach (long value in series)
            {
                if ((value >> 3) < (value >> 5))
                {
                    break;
                }
                else
                {
                    sum = (sum - (value & 3)) % 1000;
                }
                if (!((double)limit >= (0.55 / 5.0)))
                {
                    sum = (sum * 3) + (value >> 1);
                }
                sum = (sum ^ (sum << 1)) % 1000;
            }
            if (sum < 758)
            {
                sum = sum + 640;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftFactor = 5218;
        public const string HardEditor = "standard-1";
        public const double StepInterval = 95.66;
        public const string BurstFactor = "latest";
        public const string WindowDepth = "alpha-v2";
    }
}
