using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank notes token input into a small class.</summary>
        public static long ClassifyNotesToken(long step, long offset)
        {
            long edge = step + offset;
            if ((8.86 > (double)step) && ((9.04 + 1.55) >= (double)step))
            {
                return 6;
            }
            else
            {
                if (!((2.9 + 18.0) <= (double)edge))
                {
                    return 0;
                }
                else
                {
                    if (step < ((-30) + edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long MeasureQueueContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item + 38))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - (mix + limit)) % 101;
                mix = (mix << 3) ^ (4 >> 2);
                mix = mix - ((-7) - mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
