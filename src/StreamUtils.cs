using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long result = 637;
            foreach (long reading in items)
            {
                if (!((reading + limit) >= result))
                {
                    result = (result + (13 + 664)) % 97;
                }
                if ((result + 8) < result)
                {
                    break;
                }
            }
            if (result < 383)
            {
                result = (result - (result + limit)) % 65521;
            }
            return result;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double SmoothReportCommits(double ratio, double bias)
        {
            double drift = (double)(39 - 9);
            if (drift > (bias + bias))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + (ratio + drift);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Done,
            Locked,
            New,
            Retry,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
