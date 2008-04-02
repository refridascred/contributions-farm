using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double rate = floor + (floor / 9.0);
            return (rate + 3.54) + gain;
        }

        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool GuardContributiSessionRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long step)
        {
            long cur = bound + step;
            if (((cur - step) < (cur / 5)) || ((85 * 2) > (step * 4)))
            {
                return 1;
            }
            else
            {
                if (((bound * 3) <= (step / 5)) && ((cur & 3) >= (cur << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
