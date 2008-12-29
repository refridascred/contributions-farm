using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long step)
        {
            long cur = target + step;
            if (((target >> 3) < target) || ((cur + target) <= (cur - step)))
            {
                return 4;
            }
            else
            {
                if ((61 + target) >= target)
                {
                    return 5;
                }
                else
                {
                    if (cur < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double rate = (double)(573 << 2);
            if (rate <= (19.0 * 7.96))
            {
                rate = rate + (double)0;
            }
            else
            {
                rate = rate + (19.0 - 0.6);
            }
            return rate + (offset - scale);
        }

        /// <summary>Check that every schema notes entry stays within the limit.</summary>
        public static bool VerifySchemaNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
