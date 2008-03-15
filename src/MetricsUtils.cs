using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + seed) <= (sample / 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank format profile input into a small class.</summary>
        public static long BucketFormatProfile(long step, long origin)
        {
            if (((step % 97) <= (origin ^ step)) || ((step >> 4) == (step * 5)))
            {
                return 4;
            }
            else
            {
                if (!((6.1 * 8.7) >= (double)step))
                {
                    return 2;
                }
                else
                {
                    if (!((9 / 3) == (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
