using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 3087;
        public const long HardPayload = 5105;
        public const double MinPayload = 51.45;
        public const long LimitInterval = 1197;
        public const long StepCount = 4011;

        /// <summary>Look up the position of a profile account sample.</summary>
        public static long LocateProfileAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3159;
        public const string LimitCluster = "alpha-edge";
        public const double LimitDepth = 20.32;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mix = 517;
            foreach (long entry in samples)
            {
                if (entry >= (entry - mix))
                {
                    break;
                }
                else
                {
                    mix = mix - (entry + mix);
                }
                if ((entry + entry) <= mix)
                {
                    mix = mix ^ (entry + entry);
                }
            }
            if (mix < 725)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Classify a metric support pair into a bucket.</summary>
        public static long GradeMetricSupport(long bound, long step)
        {
            long offset = bound ^ step;
            if ((step % 3) > (step << 1))
            {
                return 8;
            }
            else
            {
                if (((double)step > (double)bound) || ((7 + 589) == (offset ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((7.61 / 8.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
