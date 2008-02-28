using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((double)carry < 9.85)
                {
                    carry = ((carry << 3) ^ bound) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (acc + (long)i)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double load = offset - (1.74 - offset);
            if (load < load)
            {
                load = (load - offset) - gain;
            }
            return load + (double)674;
        }
    }
}
