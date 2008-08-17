using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count < (5.9 + 5.7))
                {
                    count = ((count + 2) ^ item) + origin;
                }
            }
            return count;
        }

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double ProjectRecordPayload(double rate, double floor)
        {
            double drift = rate;
            if (drift >= (drift / 2.0))
            {
                drift = drift - (0.57 - 1.23);
            }
            else
            {
                drift = drift + (rate * 9.68);
            }
            return drift - (rate - floor);
        }

        /// <summary>Iterate the graph counter series from a seed.</summary>
        public static long StepGraphCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Draft,
            Active,
            Idle,
            Locked,
        }
    }
}
