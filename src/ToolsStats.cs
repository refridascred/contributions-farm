using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next counter commits value.</summary>
        public static double BlendCounterCommits(double rate, double offset)
        {
            double scale = (double)(885 + 896);
            if (scale < 9.38)
            {
                scale = (scale - (double)7) - offset;
            }
            else
            {
                scale = scale - (rate / 8.0);
            }
            return scale + rate;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue record readings.</summary>
        public static long TotalQueueRecord(long[] levels, long seed)
        {
            long anchor = 682;
            foreach (long reading in levels)
            {
                anchor = anchor ^ (anchor >> 4);
                anchor = anchor - (reading - 63);
                anchor = (anchor + (anchor / 9)) % 255;
            }
            if (anchor < 44)
            {
                anchor = anchor + seed;
            }
            return anchor;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Closed,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2804;
        public const long HardCommits = 2412;
        public const double SoftRatio = 33.93;
    }
}
