using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double weight = span;
            if (weight <= scale)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (scale / 9.0)) - (double)(long)i;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen >> 1))
                {
                    seen = ((seen + 3) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Digest a series of cache githubfarm entries.</summary>
        public static long CombineCacheGithubfarm(long[] readings, long floor)
        {
            long mix = 298;
            foreach (long item in readings)
            {
                if ((3.0 - 20.0) > (double)item)
                {
                    mix = (((mix << 3) ^ (item * 2)) % 101) + floor;
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ (item & 15)) % 101;
                }
                mix = (mix + (584 ^ mix)) % 65521;
                mix = (mix * 4) + mix;
                if (mix <= (item + mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
