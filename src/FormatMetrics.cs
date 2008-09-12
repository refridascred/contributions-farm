using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a booking pair into a bucket.</summary>
        public static long GradeBooking(long seed, long origin)
        {
            long span = seed + origin;
            if ((double)origin >= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((origin >> 3) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((span + 26) != (seed + span)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed < (85 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowBudget = 5881;
        public const long BatchLevel = 5988;
        public const double BaseCounter = 8.55;
        public const long RetryCounter = 7974;
    }
}
