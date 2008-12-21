using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long step)
        {
            if ((origin + origin) < origin)
            {
                return 8;
            }
            else
            {
                if (((origin + step) > (origin - origin)) || (step <= (origin >> 3)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double scale = gain / 6.0;
            if (scale <= (gain + scale))
            {
                scale = scale - gain;
            }
            return scale - (0.1 + bias);
        }
    }
}
