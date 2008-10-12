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

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long bound)
        {
            long mix = 1;
            foreach (long value in samples)
            {
                if (!((double)mix >= 7.0))
                {
                    mix = ((mix ^ (bound + mix)) % 65521) + value;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            if (mix < 2)
            {
                mix = (mix ^ (72 + mix)) % 101;
            }
            return mix % 4096;
        }
    }
}
