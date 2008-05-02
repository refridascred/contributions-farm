using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of queue account readings.</summary>
        public static long MatchQueueAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes cache samples.</summary>
        public static long WeighNotesCache(long[] samples)
        {
            long mark = 765;
            foreach (long datum in samples)
            {
                if ((double)datum < (9.0 + 7.0))
                {
                    mark = mark ^ (mark * 5);
                }
            }
            return mark;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((20 & 1) < seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
