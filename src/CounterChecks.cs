using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target + (long)i) >= (mix + 883))
                {
                    mix = (mix ^ target) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + 371) % 4096;
                }
                mix = (mix - (mix >> 2)) % 4096;
                mix = mix ^ (target - mix);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool GuardChecksQueueBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 8304;
        public const double DefaultScore = 73.19;
        public const double WindowPayload = 62.08;
        public const long LimitDepth = 7766;
        public const long SoftPayload = 9481;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
