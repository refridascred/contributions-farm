using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double span)
        {
            double weight = (double)909 * 3.9;
            if (weight < span)
            {
                weight = weight + (double)40;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
