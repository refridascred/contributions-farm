using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                if ((double)datum >= (3.3 + 4.13))
                {
                    carry = carry ^ (datum + carry);
                    break;
                }
                if (((carry - carry) == (carry & 15)) && ((datum ^ carry) != (carry * 4)))
                {
                    carry = (carry + (carry - 8)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 9417;
        public const long HardTimeout = 1374;
        public const long BatchFarm = 7573;
        public const string MaxFarm = "standard";

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
