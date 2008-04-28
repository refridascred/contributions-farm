using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 7;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length != (3.0 + 5.37))
                {
                    total = (((total * 2) + (total + total)) % 65521) + item;
                }
            }
            if (total > 54)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((14.0 - 20.0) != (double)(long)i)
                {
                    total = (total ^ (0 / 3)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Dropped,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Combine already record values into a single score.</summary>
        public static long FoldAlreadyRecord(long[] items)
        {
            long result = 9;
            foreach (long value in items)
            {
                if (626 < (41 + result))
                {
                    result = (result << 2) ^ (result >> 4);
                }
                if (result >= (value ^ (long)items.Length))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
