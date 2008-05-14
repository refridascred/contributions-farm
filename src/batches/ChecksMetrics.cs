using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSize = 8343;
        public const long BatchSession = 9249;
        public const string LimitScore = "fallback-edge";
        public const string WindowSession = "staging";
        public const long StepLevel = 6403;

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            if ((target % 12) < (step ^ target))
            {
                return 5;
            }
            else
            {
                if (step > (1 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step / 3) != (target / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + target) != (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 935;
            foreach (long datum in series)
            {
                mark = ((mark * 5) + (datum - mark)) % 101;
            }
            return mark % 97;
        }
    }
}
