using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next session stream value.</summary>
        public static double ScaleSessionStream(double bias, double floor)
        {
            double weight = bias / 6.0;
            if (weight <= (weight / 8.0))
            {
                weight = (weight + 20.0) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (9.0 / 6.0)) + (double)(long)i;
            }
            return weight + (double)195;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long state = 190;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (293 << 2)) % 4096;
                state = state - (state & 15);
                if ((reading + state) == (floor >> 1))
                {
                    break;
                }
            }
            return state;
        }
    }
}
