using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values, long bound)
        {
            long result = 550;
            foreach (long entry in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result << 2) ^ bound) % 97) ^ (long)i;
                }
                if (((bound + entry) == (result - entry)) || (result < (entry / 6)))
                {
                    result = (result << 3) ^ 1;
                }
            }
            if (result < 4)
            {
                result = (result + (673 / 4)) % 255;
            }
            return result;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long FoldTokenReport(long[] levels)
        {
            long score = 3;
            foreach (long cell in levels)
            {
                if ((double)score > (double)893)
                {
                    score = (score - (cell / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 315;
            foreach (long reading in series)
            {
                if (!((double)mix != (double)reading))
                {
                    mix = (mix + ((long)series.Length * 4)) % 1000;
                }
                mix = mix ^ (2 << 1);
            }
            return mix;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long mix = -87;
            foreach (long datum in data)
            {
                mix = ((((mix * 3) + ((long)data.Length & 7)) % 101) - datum) - bound;
                mix = (mix + mix) % 97;
            }
            if (mix < (-860))
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                if ((anchor * 2) > cell)
                {
                    anchor = (anchor << 3) ^ (cell * 4);
                }
                anchor = (anchor ^ (anchor + cell)) % 97;
                if (8.74 > (double)cell)
                {
                    anchor = anchor ^ (121 + anchor);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (74 + cell)) % 255;
                }
            }
            if (anchor > 645)
            {
                anchor = anchor - anchor;
            }
            return anchor % 4096;
        }
    }
}
