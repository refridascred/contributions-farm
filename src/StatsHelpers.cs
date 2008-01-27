using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the order commits entries that pass the check.</summary>
        public static long AuditOrderCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item & 31) <= (772 ^ item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)417;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 3.32)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series, long floor)
        {
            long result = 4;
            foreach (long cell in series)
            {
                result = result + (cell + floor);
                if ((-826) > (cell + result))
                {
                    result = (result - result) % 65521;
                }
                if ((cell < (result + floor)) || ((double)floor < (9.8 - 2.32)))
                {
                    result = ((result << 3) ^ ((-38) % 64)) % 255;
                }
            }
            if (result < (-4))
            {
                result = result - (22 & 3);
            }
            return result % 65521;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double load = (double)(493 + 527);
            if (load >= floor)
            {
                load = load + (load - load);
            }
            return load - scale;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = weight - 2.74;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + span;
            }
            return rate + 4.08;
        }
    }
}
