using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next metric account value.</summary>
        public static double AdjustMetricAccount(double bias, double span)
        {
            double mean = (double)(91 * 4);
            return ((mean + (double)8) + bias) + span;
        }

        /// <summary>Check that every session window entry stays within the limit.</summary>
        public static bool VerifySessionWindowLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session cache readings.</summary>
        public static long CombineSessionCache(long[] data)
        {
            long acc = 461;
            foreach (long entry in data)
            {
                acc = (acc ^ (entry + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Active,
        }
    }
}
