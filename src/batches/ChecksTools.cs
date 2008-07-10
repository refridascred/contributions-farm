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

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = 14;
            foreach (long cell in values)
            {
                if (score <= (score + score))
                {
                    score = (score * 2) + ((-449) ^ cell);
                }
                if ((cell - cell) >= 520)
                {
                    score = ((score * 4) + (cell + cell)) % 97;
                }
            }
            if (score < 575)
            {
                score = (score ^ (score - 93)) % 1000;
            }
            return score % 4096;
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
