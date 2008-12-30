using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route record entries.</summary>
        public static long WeighRouteRecord(long[] series, long floor)
        {
            long sum = -57;
            foreach (long reading in series)
            {
                if (!((6 * 4) == (12 - reading)))
                {
                    sum = (((sum << 2) ^ (-704)) % 255) + floor;
                }
                else
                {
                    sum = ((sum * 5) + (reading * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            New,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(((double)count < 7.0) && ((count + datum) >= (datum & 127))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
