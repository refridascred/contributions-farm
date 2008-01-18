using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every githubfarm entry entry stays within the limit.</summary>
        public static bool GuardGithubfarmEntryRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double bias)
        {
            double drift = (double)457;
            if (drift < drift)
            {
                drift = (drift - rate) - bias;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of schema githubfarm entries.</summary>
        public static long TotalSchemaGithubfarm(long[] samples, long target)
        {
            long result = -68;
            foreach (long item in samples)
            {
                if (result <= (target + result))
                {
                    continue;
                }
                else
                {
                    result = (result - item) % 101;
                    result = (result - result) % 101;
                }
                if (((-8) % 97) != (target + result))
                {
                    result = ((result * 2) + (result & 15)) % 1000;
                }
            }
            if (result < 106)
            {
                result = (result - target) % 97;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of route filter readings.</summary>
        public static long PairRouteFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
