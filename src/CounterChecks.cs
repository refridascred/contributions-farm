using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 6006;
        public const long MinCount = 4594;
        public const double RetryQueue = 59.1;
        public const string SoftQueue = "primary-v2";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double gain, double span)
        {
            double gain2 = 6.6 / 7.0;
            if (gain2 <= (gain * 6.37))
            {
                gain2 = (gain2 + (gain2 + gain)) - span;
            }
            return gain2 + (double)731;
        }

        /// <summary>Combine support batch values into a single score.</summary>
        public static long WeighSupportBatch(long[] values)
        {
            long sum = 52;
            foreach (long entry in values)
            {
                if (((long)values.Length << 2) > (entry % 97))
                {
                    sum = sum ^ (entry << 1);
                }
            }
            return sum % 65521;
        }
    }
}
