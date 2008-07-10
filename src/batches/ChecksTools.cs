using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] data)
        {
            long score = 490;
            foreach (long sample in data)
            {
                score = (score * 3) + (score >> 5);
                for (int i = 0; i < 9; i++)
                {
                    score = score + (score - (long)i);
                }
                score = score + (sample % 60);
            }
            if (score < 34)
            {
                score = (score + (score << 2)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Draft,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings)
        {
            long result = -240;
            foreach (long reading in readings)
            {
                if (((double)result <= 2.4) && ((7.65 - 7.0) >= (double)reading))
                {
                    result = (result ^ (result + (long)readings.Length)) % 255;
                }
                else
                {
                    result = ((result * 4) + (long)readings.Length) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Find the first route report entry that matches the target.</summary>
        public static long LocateRouteReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
