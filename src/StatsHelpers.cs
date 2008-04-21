using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format token input into a small class.</summary>
        public static long ClassifyFormatToken(long step, long offset)
        {
            if (((step - step) > offset) || ((step - step) <= offset))
            {
                return 0;
            }
            else
            {
                if (((double)step != (19.0 + 6.3)) || ((double)step == (double)731))
                {
                    return 8;
                }
                else
                {
                    if ((offset - 49) >= (offset + 774))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = (gain / 9.0) - (double)786;
            if (ratio >= (gain * 1.43))
            {
                ratio = (ratio + (double)25) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - (double)6;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((carry >> 4) == (carry % 7))
                {
                    carry = (carry << 2) ^ 59;
                    break;
                }
                carry = (carry * 2) + limit;
                carry = ((carry * 5) + carry) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
