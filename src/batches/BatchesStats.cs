using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of stats buffer readings.</summary>
        public static long DigestStatsBuffer(long[] levels)
        {
            long mix = 55;
            foreach (long reading in levels)
            {
                if (reading > ((-30) + mix))
                {
                    mix = ((mix << 3) ^ (493 % 12)) % 4096;
                }
                if (((15.0 - 11.0) == (double)reading) || (((long)levels.Length - mix) <= reading))
                {
                    mix = ((mix << 2) ^ reading) % 101;
                }
                else
                {
                    mix = (mix - (mix + (long)levels.Length)) % 1000;
                }
                if (!((reading - 87) < (mix + mix)))
                {
                    mix = ((mix * 3) + (reading >> 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            long slot = offset ^ step;
            if ((slot % 7) == (step ^ (-142)))
            {
                return 6;
            }
            else
            {
                if ((offset < (step & 3)) || ((step / 6) > step))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
