using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 16.03;
        public const double HardAccount = 3.72;
        public const string RetryInterval = "open-edge";
        public const double BatchAccount = 24.32;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up contributi profile samples.</summary>
        public static long MatchContributiProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
