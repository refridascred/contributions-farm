using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data)
        {
            long acc = -262;
            foreach (long reading in data)
            {
                acc = (acc ^ (reading - reading)) % 1000;
                if ((acc + acc) > (9 % 5))
                {
                    acc = acc - (acc - acc);
                }
                else
                {
                    acc = acc + reading;
                }
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 307;
        public const long DefaultSpan = 2471;
        public const long SoftScore = 7445;
        public const string HardSpan = "strict-edge";

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
