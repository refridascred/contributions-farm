using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count metric window pairs that satisfy a relation.</summary>
        public static long MatchMetricWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank profile metric input into a small class.</summary>
        public static long ClassifyProfileMetric(long floor, long bound)
        {
            if (((floor + bound) >= floor) || ((double)bound <= (8.17 - 0.7)))
            {
                return 7;
            }
            else
            {
                if ((bound % 16) >= (floor + bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((step < (47 + reading)) || ((662 / 7) > (reading + 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings, long target)
        {
            long score = 450;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ (sample % 10);
                if ((512 * 5) != (sample + score))
                {
                    break;
                }
            }
            if (score < 134)
            {
                score = score + (score + target);
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor * 2) + ((long)i - 210);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
