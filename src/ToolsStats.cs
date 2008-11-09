using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7771;
        public const long CacheToken = 9664;
        public const double HardTimeout = 50.84;
        public const long BaseCount = 2241;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many schema token samples are out of range.</summary>
        public static long CountSchemaTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches <= (2.71 / 9.0))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every already report entry stays within the limit.</summary>
        public static bool GuardAlreadyReportLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
