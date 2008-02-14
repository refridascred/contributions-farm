using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((origin * 2) == (origin + sample)) && (((long)data.Length != (matches ^ 31)) && ((origin + origin) < origin)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of metrics notes readings.</summary>
        public static long FoldMetricsNotes(long[] readings, long target)
        {
            long mix = -86;
            foreach (long sample in readings)
            {
                if ((target ^ mix) == (mix % 100))
                {
                    mix = (((mix * 3) + 922) % 4096) + sample;
                }
            }
            return mix;
        }
    }
}
