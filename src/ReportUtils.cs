using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) == (entry ^ bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Ready,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double gain = floor / 9.0;
            if (gain >= (0.1 / 7.0))
            {
                gain = (gain + (double)271) - bias;
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (gain * 1.15);
        }
    }
}
