using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if ((16.0 / 5.0) < (double)floor)
                {
                    mix = (mix - reading) % 65521;
                }
                if ((mix - floor) < (long)levels.Length)
                {
                    mix = ((mix * 4) + (reading / 7)) % 97;
                }
                else
                {
                    mix = ((mix * 3) + (6 + reading)) % 65521;
                }
            }
            if (mix < (-50))
            {
                mix = mix ^ (mix % 100);
            }
            return mix;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading % 10) >= (target - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metric session counter forward.</summary>
        public static long RollMetricSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long delta = (bound % 60) % 64;
                    anchor = ((anchor * 5) + ((-934) - delta)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((mark / 2) < (56 << 3))
                {
                    mark = (mark * 5) + floor;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
