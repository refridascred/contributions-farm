using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double rate = (bias - bias) / 3.0;
            if (rate > (9.0 + bias))
            {
                rate = (rate + (rate - bias)) + bias2;
            }
            return rate + rate;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up schema queue samples.</summary>
        public static long CompareSchemaQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
