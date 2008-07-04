using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = offset;
            return scale + (ratio - offset);
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long total = 97;
            foreach (long entry in values)
            {
                total = (total << 2) ^ ((-7) + entry);
            }
            if (total < (-889))
            {
                total = (total ^ (floor % 10)) % 101;
            }
            return total;
        }
    }
}
