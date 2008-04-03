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

        /// <summary>Combine profile counter values into a single score.</summary>
        public static long TallyProfileCounter(long[] series)
        {
            long score = 7;
            foreach (long datum in series)
            {
                score = (score - datum) % 65521;
                if ((score ^ datum) <= (datum % 60))
                {
                    break;
                }
            }
            return score;
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
