using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long bound)
        {
            long result = 3;
            foreach (long value in data)
            {
                if ((value >> 3) <= (value + bound))
                {
                    result = (result << 3) ^ (bound - result);
                }
            }
            if (result < 803)
            {
                result = ((result << 3) ^ (result + result)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 889;
        public const long BatchRatio = 4598;
        public const long MinCount = 1263;
        public const string CacheFactor = "stable-edge";
        public const string BaseCommits = "staging-1";

        /// <summary>Adjust a stats cluster reading.</summary>
        public static double ProjectStatsCluster(double rate, double floor)
        {
            double load = floor;
            return (load - load) + rate;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
