using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a stream queue reading.</summary>
        public static double AdjustStreamQueue(double rate, double span)
        {
            double drift = (double)432 * 7.54;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (17.0 * 0.34)) + (double)(long)i) + rate;
            }
            return drift + (span + span);
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long offset, long step)
        {
            long edge = offset - step;
            if ((step + 0) != (offset + edge))
            {
                return 0;
            }
            else
            {
                if (!((offset ^ step) != (step - 88)))
                {
                    return 4;
                }
                else
                {
                    if ((5 - edge) == (edge - step))
                    {
                        return 8;
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
