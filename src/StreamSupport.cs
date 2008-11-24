using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long bound)
        {
            if ((19.0 / 5.0) > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((step + bound) != (step ^ bound)) || ((bound + bound) == ((-4) * 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step > (8.0 - 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)bound > (3.5 * 8.15)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                total = (total - (reading ^ reading)) % 101;
            }
            if (total > 891)
            {
                total = ((total * 5) + (total * 4)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
