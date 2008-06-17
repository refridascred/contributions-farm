using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long target)
        {
            if (limit > (target >> 4))
            {
                return 6;
            }
            else
            {
                if ((target * 3) > (5 / 7))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 8) <= (target - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 2) < (target - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double load = weight;
            if (load >= (weight - load))
            {
                load = load - (double)(-46);
            }
            return load + (span * 7.51);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
