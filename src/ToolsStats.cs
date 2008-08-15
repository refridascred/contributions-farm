using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data)
        {
            long result = 4;
            foreach (long datum in data)
            {
                if ((double)95 > (double)datum)
                {
                    result = result + (result + 0);
                    break;
                }
                else
                {
                    result = result ^ (729 << 1);
                }
                if (((result * 3) < (result / 8)) && ((long)data.Length >= datum))
                {
                    result = result + (4 / 9);
                }
                else
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            if (result < 11)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin - origin) > (long)i)
                {
                    state = (state ^ ((long)i * 3)) % 97;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double bias2 = offset * 1.0;
            if (bias2 <= (bias + bias))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (offset * 9.72);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Idle,
            Dropped,
            Done,
        }
    }
}
