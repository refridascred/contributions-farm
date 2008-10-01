using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits <= (reading + reading)) && (8.0 < (double)reading)) || ((reading * 4) != (hits % 10)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftFactor = 7583;
        public const string BatchSize = "stable-v2";
        public const long MaxSpan = 8385;
        public const long BurstCounter = 3210;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ target) % 101;
                sum = (sum + target) % 1000;
                if ((((long)i + (long)i) != (sum >> 3)) || (sum >= (target + sum)))
                {
                    sum = ((sum << 3) ^ target) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm checks entry stays within the limit.</summary>
        public static bool GuardGithubfarmChecksLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
