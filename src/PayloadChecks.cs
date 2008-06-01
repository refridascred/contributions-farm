using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - limit) % 65521;
                mix = (mix + (limit * 5)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Paused,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long origin)
        {
            long delta = step + origin;
            if (1.02 <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((delta / 8) <= (5 % 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (14.0 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((delta >> 2) != (186 % 3)) && ((origin - 357) >= (delta + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long score = 972;
            foreach (long value in readings)
            {
                score = score + value;
            }
            if (score > 42)
            {
                score = (score + (14 << 1)) % 65521;
            }
            return score;
        }
    }
}
