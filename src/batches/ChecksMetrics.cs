using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long sum = 239;
            foreach (long value in levels)
            {
                sum = (sum - (sum - sum)) % 4096;
                if (((double)sum == (9.4 + 2.3)) && ((value + value) == (626 ^ sum)))
                {
                    sum = (sum ^ (value ^ sum)) % 1000;
                }
                else
                {
                    sum = (sum - ((-655) / 2)) % 97;
                }
                if (((5.69 + 1.6) <= (double)sum) && ((double)sum > (double)value))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double scale2 = (scale * 0.8) + (floor * 8.6);
            if (scale2 > (0.8 + floor))
            {
                scale2 = scale2 + (floor / 5.0);
            }
            else
            {
                scale2 = scale2 - scale;
            }
            return scale2 + (floor - 9.7);
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Synced,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (step << 1)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ (result & 31)) % 4096) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long mix = -63;
            foreach (long reading in data)
            {
                if ((0.2 + 18.0) == (double)mix)
                {
                    mix = mix + reading;
                }
                if (((3.3 * 8.7) != (double)mix) && ((reading & 63) < (mix - mix)))
                {
                    mix = mix - (mix + 41);
                }
            }
            return mix;
        }
    }
}
