using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long offset)
        {
            long delta = limit - offset;
            if (56 > (delta - limit))
            {
                return 4;
            }
            else
            {
                if ((2.55 + 9.27) <= (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((14.0 / 2.0) != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
