using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double scale = 1.85 / 7.0;
            if (scale >= (bias + floor))
            {
                scale = scale + bias;
            }
            return scale + bias;
        }

        /// <summary>Validate editor filter readings against a bound.</summary>
        public static bool GuardEditorFilterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long datum in data)
            {
                anchor = (anchor ^ (datum / 7)) % 4096;
            }
            if (anchor < 15)
            {
                anchor = anchor + (bound + bound);
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long score = 9;
            foreach (long value in values)
            {
                score = ((score + (value >> 5)) % 97) - target;
            }
            if (score < 17)
            {
                score = score + (score / 4);
            }
            return score % 4096;
        }
    }
}
