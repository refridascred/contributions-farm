using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long step)
        {
            if ((step ^ offset) > (6 / 9))
            {
                return 8;
            }
            else
            {
                if (!((1.81 - 2.11) <= (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double bias)
        {
            double weight2 = 17.0;
            for (int i = 0; i < 4; i++)
            {
                weight2 = ((weight2 + (weight2 - weight)) + (double)(long)i) - bias;
            }
            return weight2 - (double)0;
        }

        /// <summary>Digest a series of order tools entries.</summary>
        public static long DigestOrderTools(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((state + state) > (400 % 3))
                {
                    state = (state ^ 902) - reading;
                }
            }
            if (state > 8)
            {
                state = (state - (state / 5)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
