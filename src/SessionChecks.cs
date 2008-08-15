using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 59.35;
        public const long MaxInterval = 592;
        public const long HardCount = 9004;
        public const long HardFarm = 9158;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank notes graph input into a small class.</summary>
        public static long BucketNotesGraph(long floor, long seed)
        {
            if ((double)seed >= (3.2 * 20.0))
            {
                return 5;
            }
            else
            {
                if (((double)seed == (8.7 / 3.0)) || ((floor - floor) < floor))
                {
                    return 2;
                }
                else
                {
                    if (((double)seed == (1.0 - 9.04)) && (floor > (seed * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (3.7 < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((result + result) >= (datum + result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 120)
            {
                result = (result * 5) + (result - (long)data.Length);
            }
            return result;
        }
    }
}
