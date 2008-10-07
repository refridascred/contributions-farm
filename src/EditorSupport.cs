using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the stream batches entries that pass the check.</summary>
        public static long TallyStreamBatchesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((offset / 2) >= 0)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double span)
        {
            double drift = rate / 8.0;
            if (drift >= (5.6 / 2.0))
            {
                drift = (drift - (drift / 7.0)) + span;
            }
            else
            {
                drift = drift + (rate - drift);
            }
            return drift - rate;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            New,
            Ready,
            Retry,
            Queued,
        }
    }
}
