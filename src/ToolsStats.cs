using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    score = (score - (long)i3) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate token notes samples.</summary>
        public static long WeighTokenNotes(long[] items)
        {
            long sum = 43;
            foreach (long datum in items)
            {
                if (((double)sum < (4.2 / 6.0)) && ((datum ^ sum) < (sum + datum)))
                {
                    sum = (sum + 505) % 97;
                }
                else
                {
                    sum = sum + (datum % 10);
                }
            }
            return sum;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 3488;
        public const double IdleGraph = 56.44;
        public const double HardTimeout = 37.85;
        public const long IdleWidth = 193;

        /// <summary>Locate a stream record reading by value.</summary>
        public static long LocateStreamRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer stats measurements.</summary>
        public static double BlendBufferStats(double bias, double offset)
        {
            double bias2 = (offset + offset) / 2.0;
            if (bias2 < bias2)
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - (bias * 7.24);
        }
    }
}
