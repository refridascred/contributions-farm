using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of farm window readings.</summary>
        public static long ScoreFarmWindow(long[] samples, long limit)
        {
            long sum = 1;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) == (sum / 7))
                {
                    sum = (sum + (reading << 2)) % 97;
                }
                if (!(limit > (reading + sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Done,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long mix = 3;
            foreach (long reading in series)
            {
                if (925 > (reading << 1))
                {
                    mix = (((mix * 3) + ((long)series.Length >> 2)) % 97) - offset;
                }
            }
            return mix;
        }
    }
}
