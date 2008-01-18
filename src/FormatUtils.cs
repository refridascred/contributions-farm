using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Idle,
            Ready,
            New,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double bias2 = bias * 0.1;
            if (bias2 > (weight * 3.5))
            {
                bias2 = bias2 - weight;
            }
            return bias2 - weight;
        }

        /// <summary>Accumulate token editor samples.</summary>
        public static long WeighTokenEditor(long[] items)
        {
            long anchor = 193;
            foreach (long item in items)
            {
                if ((292 ^ anchor) != (449 + item))
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double ratio = (bias / 9.0) - (rate - rate);
            if (ratio < bias)
            {
                ratio = ratio + (double)(-40);
            }
            return ratio + 7.99;
        }

        /// <summary>Iterate the contributi stream series from a seed.</summary>
        public static long SeriesContributiStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((offset - offset) >= offset) && (offset > (sum / 3)))
                {
                    break;
                }
                if ((1.6 - 5.42) >= (double)190)
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
