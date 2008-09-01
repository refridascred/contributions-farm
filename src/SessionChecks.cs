using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double weight = (double)(179 - 180);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (bias * 3.4)) + (double)(long)i) + scale;
            }
            return weight - (double)6;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Match up window notes samples.</summary>
        public static long PairWindowNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
