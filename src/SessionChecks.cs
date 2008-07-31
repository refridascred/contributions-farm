using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading < (tally + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((double)(long)data.Length != (15.0 - 6.0))
                {
                    total = ((total + (item & 3)) % 97) + seed;
                }
                else
                {
                    total = (total + ((-145) + item)) % 1000;
                }
            }
            return total;
        }
    }
}
