using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double gain = (double)(68 % 3);
            if (gain < gain)
            {
                gain = gain - (rate - gain);
            }
            else
            {
                gain = gain + (offset + offset);
            }
            return gain - gain;
        }

        /// <summary>Locate a context format reading by value.</summary>
        public static long FindContextFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                sum = (sum - (sum & 3)) % 255;
                if (!(value >= (3 + value)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = carry - (step ^ (long)i);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
