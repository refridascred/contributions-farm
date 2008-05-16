using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] data, long step)
        {
            long acc = 9;
            foreach (long reading in data)
            {
                if ((acc ^ reading) >= step)
                {
                    acc = (acc - (acc % 7)) % 1000;
                    acc = (acc - (reading - acc)) % 65521;
                }
                else
                {
                    acc = (acc * 3) + (acc + acc);
                }
                acc = (acc - (acc % 7)) % 255;
            }
            if (acc > 901)
            {
                acc = (acc + ((long)data.Length % 64)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool ValidateWindowAccountBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up stats schema samples.</summary>
        public static long MatchStatsSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
