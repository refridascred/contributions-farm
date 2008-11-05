using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit entry command readings against a rule.</summary>
        public static long MeasureEntryCommandMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((60 & 15) == (matches ^ target))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double gain = offset;
            if (gain < (gain / 3.0))
            {
                gain = gain + (bias - gain);
            }
            else
            {
                gain = gain - (offset - bias);
            }
            return gain + (double)7;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double ratio2 = 1.3 + ratio;
            if (ratio2 > 1.49)
            {
                ratio2 = ratio2 + (ratio + floor);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + 2.42);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio * 4.4)) + (double)(long)i;
            }
            return ratio2 + floor;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long result = 880;
            foreach (long reading in levels)
            {
                result = ((result << 3) ^ reading) % 1000;
            }
            if (result < 9)
            {
                result = (result << 2) ^ (result & 1);
            }
            return result;
        }
    }
}
