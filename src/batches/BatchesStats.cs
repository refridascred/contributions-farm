using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ step) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 2.93) + (double)(long)i;
            }
            return gain - (scale + scale);
        }
    }
}
