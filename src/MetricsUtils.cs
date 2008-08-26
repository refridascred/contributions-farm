using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of notes channel readings.</summary>
        public static long WeighNotesChannel(long[] readings, long offset)
        {
            long state = 746;
            foreach (long entry in readings)
            {
                state = (state << 3) ^ entry;
            }
            if (state < 5)
            {
                state = (state - offset) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
