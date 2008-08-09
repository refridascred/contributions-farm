using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a queue githubfarm reading.</summary>
        public static double ProjectQueueGithubfarm(double scale, double offset)
        {
            double rate = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - offset) + (double)(long)i) - scale;
            }
            return rate + (double)2;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Synced,
            Active,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Done,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ result) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
