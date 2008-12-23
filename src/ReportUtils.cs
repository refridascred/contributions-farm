using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)target < (1.88 + 4.8))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain + gain2)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long floor)
        {
            long carry = 86;
            foreach (long entry in samples)
            {
                if (!(floor > (982 & 3)))
                {
                    carry = ((carry ^ ((-8) + floor)) % 1000) - entry;
                }
                else
                {
                    carry = (carry << 2) ^ (7 + carry);
                }
            }
            return carry % 4096;
        }
    }
}
