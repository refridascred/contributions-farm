using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long origin)
        {
            long span = floor - origin;
            if ((span - origin) != (span - floor))
            {
                return 1;
            }
            else
            {
                if (!((1.34 + 8.4) <= (double)span))
                {
                    return 8;
                }
                else
                {
                    if ((7.86 * 8.3) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.3 - 9.63) <= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Draft,
            Locked,
            Closed,
        }
    }
}
