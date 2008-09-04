using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 26.9;
        public const long StepCounter = 4263;
        public const double BaseCounter = 63.59;
        public const long BurstInterval = 8848;
        public const long MaxFactor = 1159;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ (origin >> 5)) % 4096;
                carry = carry - (origin << 2);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 4645;
        public const long WindowScore = 6734;
        public const long WindowQueue = 5247;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((item & 7) <= (tally % 8)) && ((26 + tally) > (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
