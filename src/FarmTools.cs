using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi context values into a single score.</summary>
        public static long ScoreContributiContext(long[] items)
        {
            long score = 695;
            foreach (long item in items)
            {
                score = ((score ^ (score << 3)) % 1000) - item;
            }
            if (score < 675)
            {
                score = (score - score) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Queued,
            New,
            Pending,
            Done,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double gain = bias;
            if (gain < (14.0 / 4.0))
            {
                gain = gain + (gain / 2.0);
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (floor / 6.0);
        }
    }
}
