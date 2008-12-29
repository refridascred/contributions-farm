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

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 3097;
        public const long HardEntry = 2370;
        public const long StepEntry = 9437;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Queued,
            New,
            Idle,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
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
