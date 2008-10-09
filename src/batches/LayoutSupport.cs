using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                if ((mark + 4) < (8 % 5))
                {
                    mark = mark ^ (cell << 1);
                }
                if (mark <= cell)
                {
                    mark = mark ^ (mark / 9);
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum > (matches - datum))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload farm counter forward.</summary>
        public static long StepPayloadFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step % 97) <= anchor)
                {
                    anchor = anchor ^ (step - anchor);
                }
                if ((9.65 + 3.2) < (double)(long)i)
                {
                    break;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor >> 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
