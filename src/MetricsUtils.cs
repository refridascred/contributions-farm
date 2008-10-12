using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long offset)
        {
            if ((double)bound >= (10.0 * 18.0))
            {
                return 5;
            }
            else
            {
                if (!((offset % 60) >= (offset << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((8.2 + 2.0) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((seed - mix) < 0))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
                else
                {
                    mix = (mix - (long)i) % 101;
                    mix = ((mix * 3) + seed) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
