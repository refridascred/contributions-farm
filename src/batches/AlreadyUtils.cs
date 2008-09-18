using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((56 - datum) > (datum % 8))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long step)
        {
            long mix = 755;
            foreach (long entry in levels)
            {
                if ((entry >> 5) < (entry / 4))
                {
                    mix = (mix ^ (entry * 5)) % 97;
                }
            }
            if (mix > 5)
            {
                mix = (mix * 3) + (step >> 4);
            }
            return mix;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Failed,
            Ready,
            Pending,
        }
    }
}
