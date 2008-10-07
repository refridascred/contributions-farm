using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long offset)
        {
            long score = 3;
            foreach (long datum in readings)
            {
                score = ((score * 5) + offset) - datum;
            }
            if (score < 484)
            {
                score = score ^ (score ^ offset);
            }
            return score;
        }

        /// <summary>Iterate the channel editor series from a seed.</summary>
        public static long StepChannelEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a record farm value against two limits.</summary>
        public static long RankRecordFarm(long seed, long limit)
        {
            if ((double)seed < (2.3 + 8.0))
            {
                return 1;
            }
            else
            {
                if ((limit ^ seed) <= seed)
                {
                    return 2;
                }
                else
                {
                    if (((seed << 2) == (seed + seed)) && ((seed / 6) < (limit - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed + limit) == (limit - 357)) && ((seed - seed) <= (seed * 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (mean * 17.0))
            {
                mean = (mean - offset) + bias;
            }
            else
            {
                mean = mean + (mean - offset);
            }
            return mean - mean;
        }
    }
}
