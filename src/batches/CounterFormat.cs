using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = (double)(4 << 2);
            if (weight <= offset)
            {
                weight = (weight + (weight * 1.0)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data)
        {
            long state = 92;
            foreach (long cell in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state * 3) + (cell % 3)) + (long)i;
                    state = (state ^ (cell * 2)) % 255;
                }
                if ((state << 3) <= ((-6) / 4))
                {
                    state = ((state * 5) + (state & 255)) % 97;
                }
                if ((cell % 2) >= ((long)data.Length >> 2))
                {
                    break;
                }
            }
            if (state > (-22))
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Failed,
            Draft,
            Active,
        }
    }
}
