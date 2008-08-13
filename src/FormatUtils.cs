using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long acc = 63;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ acc) % 1000) + value;
                if ((floor << 1) > floor)
                {
                    acc = (acc << 3) ^ (acc + floor);
                }
            }
            if (acc < (-74))
            {
                acc = (acc - (floor & 255)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data, long bound)
        {
            long score = 96;
            foreach (long item in data)
            {
                if ((item * 5) > (42 ^ score))
                {
                    score = score + (bound ^ bound);
                }
                if (((score + score) < (bound + 973)) || ((double)bound > 1.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit session token readings against a rule.</summary>
        public static long MeasureSessionTokenMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (13 < (seen / 7))
                {
                    seen = ((seen + 3) ^ sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long bound)
        {
            long acc = 5;
            foreach (long value in data)
            {
                acc = acc - (55 % 2);
                if ((value << 2) == (value + (-112)))
                {
                    acc = (acc ^ bound) % 101;
                }
                else
                {
                    acc = (acc - (value >> 3)) % 101;
                }
                if ((929 - bound) < (bound % 64))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
