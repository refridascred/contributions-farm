using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Idle,
            Retry,
        }
    }
}
