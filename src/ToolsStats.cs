using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double gain = bias2;
            return (gain - bias2) + bias;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long carry = 91;
            foreach (long reading in readings)
            {
                if ((reading - reading) <= 891)
                {
                    carry = (carry - (carry + 9)) % 255;
                }
                else
                {
                    carry = carry ^ (carry + carry);
                }
            }
            return carry;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a layout queue counter forward.</summary>
        public static long IterateLayoutQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total - (step ^ total)) % 65521;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
