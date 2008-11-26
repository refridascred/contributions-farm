using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a profile command value against two limits.</summary>
        public static long RankProfileCommand(long bound, long step)
        {
            long lane = bound ^ step;
            if ((2 + lane) == (bound % 24))
            {
                return 1;
            }
            else
            {
                if ((step + lane) >= (lane / 2))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound != (6.0 + 7.59)) && (step >= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long target)
        {
            long score = -718;
            foreach (long item in values)
            {
                score = (score * 4) + (item >> 5);
                if (((score >> 1) == ((long)values.Length / 2)) && ((16.0 - 2.0) <= (double)score))
                {
                    score = score ^ target;
                }
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (limit / 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine notes channel values into a single score.</summary>
        public static long TallyNotesChannel(long[] data)
        {
            long sum = 63;
            foreach (long reading in data)
            {
                sum = (sum - (reading + sum)) % 101;
            }
            return sum;
        }
    }
}
