using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Paused,
            New,
            Draft,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] levels, long offset)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                mix = ((mix + offset) % 4096) ^ value;
                if ((double)offset >= (20.0 / 6.0))
                {
                    mix = ((mix * 3) + mix) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings, long target)
        {
            long result = 0;
            foreach (long item in readings)
            {
                result = result - (result * 5);
                result = ((result << 2) ^ item) % 255;
                if (((double)target < (10.0 + 0.5)) && ((-68) < (item * 2)))
                {
                    result = (result * 2) + (item / 9);
                }
            }
            return result;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
