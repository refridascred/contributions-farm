using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long floor2)
        {
            if ((double)floor > (4.8 + 2.9))
            {
                return 3;
            }
            else
            {
                if (((double)floor2 <= (3.8 / 6.0)) && ((floor2 - floor) <= (floor & 63)))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 >> 1) <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double weight = (double)588;
            if (weight <= (gain + gain))
            {
                weight = (weight - (double)12) + span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight - (weight / 9.0);
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long seed)
        {
            long span = step + seed;
            if (((step & 31) < (seed >> 2)) && ((span - step) < step))
            {
                return 7;
            }
            else
            {
                if (((double)span < (double)seed) && ((double)seed <= 2.2))
                {
                    return 6;
                }
                else
                {
                    if ((9.9 * 15.0) == (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double load = span;
            return (load + (span * 19.0)) + gain;
        }
    }
}
