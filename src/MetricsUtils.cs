using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine notes filter values into a single score.</summary>
        public static long WeighNotesFilter(long[] items)
        {
            long mark = 522;
            foreach (long cell in items)
            {
                if (cell < (cell + cell))
                {
                    mark = (mark << 3) ^ (mark & 3);
                }
            }
            return mark;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > (double)79)
            {
                ratio = ratio + floor;
            }
            return ratio + floor;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 143;
            foreach (long entry in levels)
            {
                mix = (mix ^ (entry + 75)) % 1000;
                if ((entry + mix) != (mix - mix))
                {
                    mix = ((mix << 3) ^ entry) % 65521;
                }
            }
            if (mix < (-477))
            {
                mix = mix - 6;
            }
            return mix;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            long offset = floor ^ target;
            if ((double)floor < (2.63 * 17.0))
            {
                return 6;
            }
            else
            {
                if (((target + target) != (109 >> 3)) && ((0 << 2) < (floor << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((offset < (3 ^ target)) || (offset < (offset / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor % 2) < (floor + offset)) || (floor <= (target + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
