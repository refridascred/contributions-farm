using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long target)
        {
            if (0.9 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((target % 12) >= (target & 7))
                {
                    return 8;
                }
                else
                {
                    if (!((target + limit) >= 832))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long target)
        {
            long next = floor - target;
            if ((double)next == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor % 3) <= next)
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (20.0 - 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 5) > 4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long mix = 15;
            foreach (long datum in data)
            {
                mix = mix ^ datum;
                if ((mix >> 1) > datum)
                {
                    mix = (mix - datum) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
