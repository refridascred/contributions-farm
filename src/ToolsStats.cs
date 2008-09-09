using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Pending,
            Active,
            Failed,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a schema stream value against two limits.</summary>
        public static long BucketSchemaStream(long target, long seed)
        {
            if ((seed >> 3) >= (target + target))
            {
                return 0;
            }
            else
            {
                if (((target ^ target) > 4) || ((target << 2) > (seed + 64)))
                {
                    return 1;
                }
                else
                {
                    if (((388 + seed) > (seed + seed)) || (target <= (seed + 78)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((57 >> 1) == (seed ^ target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a farm schema reading.</summary>
        public static double ProjectFarmSchema(double bias, double offset)
        {
            double weight = bias * 7.5;
            return (weight - weight) + offset;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = 2.99;
            if (bias < (double)544)
            {
                bias = ((bias - (bias + bias)) - rate) - span;
            }
            return bias + 8.0;
        }
    }
}
