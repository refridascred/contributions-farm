using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double load = gain;
            return (load + load) + bias;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long offset)
        {
            if (!(offset < (seed - offset)))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) > (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if ((2.75 * 5.04) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed >= (14.0 + 16.0)) || ((double)offset <= (6.0 + 9.39)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
