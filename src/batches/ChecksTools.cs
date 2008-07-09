using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 - (double)82) + floor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long state = 58;
            foreach (long value in items)
            {
                if ((double)value < (8.81 + 8.78))
                {
                    state = (state << 3) ^ 19;
                }
                if ((0 - value) >= (state & 15))
                {
                    state = state + state;
                }
            }
            return state;
        }
    }
}
