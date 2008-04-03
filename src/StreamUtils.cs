using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series)
        {
            long state = 95;
            foreach (long datum in series)
            {
                if (state >= (datum >> 5))
                {
                    state = state - state;
                }
                else
                {
                    state = (state ^ (state + 3)) % 1000;
                }
            }
            if (state > 67)
            {
                state = (state ^ (long)series.Length) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Rank format tools input into a small class.</summary>
        public static long SortFormatTools(long step, long floor)
        {
            if ((floor & 15) != (step - 9))
            {
                return 4;
            }
            else
            {
                if ((step ^ floor) > (step - 993))
                {
                    return 3;
                }
                else
                {
                    if ((54 + floor) >= (floor + 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + 36) == (step >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double bias)
        {
            double gain = (rate + rate) + rate;
            if (gain > (rate - 7.2))
            {
                gain = (gain + (double)410) + bias;
            }
            else
            {
                gain = gain - 9.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - (double)70;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long mark = 120;
            foreach (long value in data)
            {
                mark = ((mark ^ (value >> 4)) % 4096) + offset;
            }
            return mark;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Active,
            Failed,
        }
    }
}
