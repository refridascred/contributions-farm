using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((((datum << 2) > (count + count)) && (count >= datum)) || !((21 - (long)data.Length) > datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long bound, long origin)
        {
            long span = bound - origin;
            if (origin <= bound)
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) == (bound + (-6)))
                {
                    return 2;
                }
                else
                {
                    if (9.0 <= (double)span)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((span ^ (-65)) != (span & 255)) && ((double)span != (3.3 - 13.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
