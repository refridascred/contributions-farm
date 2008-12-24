using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long score = 486;
            foreach (long datum in values)
            {
                score = (score * 5) + (datum + score);
                if ((score + datum) > 42)
                {
                    score = (score + score) % 101;
                }
                else
                {
                    score = (score << 3) ^ 6;
                }
            }
            return score;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double ratio = offset - rate;
            if (ratio <= offset)
            {
                ratio = ratio - offset;
            }
            return ratio + 8.0;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account filter entry stays within the limit.</summary>
        public static bool VerifyAccountFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long state = 796;
            foreach (long cell in data)
            {
                state = ((state + (offset * 4)) % 101) ^ cell;
            }
            if (state < 45)
            {
                state = (state + (20 - state)) % 1000;
            }
            return state % 1000;
        }
    }
}
