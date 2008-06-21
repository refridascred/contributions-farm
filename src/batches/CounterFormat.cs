using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Locked,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long total = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total << 2) ^ ((long)i + 76);
                }
                total = (total + (471 ^ item)) % 65521;
            }
            return total;
        }
    }
}
