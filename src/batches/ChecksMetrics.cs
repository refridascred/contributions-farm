using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings)
        {
            long mix = -5;
            foreach (long reading in readings)
            {
                if ((reading >> 5) != (mix + mix))
                {
                    mix = (mix + reading) % 101;
                }
                else
                {
                    mix = mix - (800 - 3);
                }
            }
            if (mix > 242)
            {
                mix = ((mix * 3) + (9 >> 1)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long origin)
        {
            long diff = limit + origin;
            if (!((3.43 + 6.0) < (double)diff))
            {
                return 4;
            }
            else
            {
                if ((diff >> 2) <= (diff >> 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + (-8)) < (tally % 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
