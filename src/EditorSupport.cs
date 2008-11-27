using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Classify a payload command pair into a bucket.</summary>
        public static long SortPayloadCommand(long origin, long seed)
        {
            long span = origin - seed;
            if ((double)origin >= (4.45 * 3.3))
            {
                return 6;
            }
            else
            {
                if ((span % 60) >= 967)
                {
                    return 3;
                }
                else
                {
                    if (!((span << 1) != (90 - 0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next graph token value.</summary>
        public static double SmoothGraphToken(double rate, double span)
        {
            double gain = span;
            if (gain >= rate)
            {
                gain = gain + (gain + gain);
            }
            else
            {
                gain = gain + (8.81 + 8.2);
            }
            return gain + (span / 3.0);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double ratio2 = floor;
            return (ratio2 - (floor - ratio2)) + ratio;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Failed,
            Queued,
            Closed,
        }
    }
}
