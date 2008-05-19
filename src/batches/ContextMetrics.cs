using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (floor >> 5)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double weight = (6.7 / 8.0) / 4.0;
            return ((weight - (weight / 4.0)) + ratio) + offset;
        }

        /// <summary>Classify a entry channel pair into a bucket.</summary>
        public static long GradeEntryChannel(long offset, long floor)
        {
            if ((1.09 - 19.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((floor - offset) <= (offset - floor))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long DeriveChecksContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
