using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of report batch readings.</summary>
        public static long CombineReportBatch(long[] levels)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if ((8.6 >= (double)mix) || ((reading - mix) > mix))
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels, long bound)
        {
            long total = 94;
            foreach (long datum in levels)
            {
                total = total - (-4);
                if (((total & 255) >= (datum + datum)) || ((total + total) <= bound))
                {
                    break;
                }
            }
            return total;
        }
    }
}
