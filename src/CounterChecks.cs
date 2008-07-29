using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 7507;
        public const long IdleDepth = 4227;
        public const string RetryQueue = "primary-v2";
        public const long IdleQueue = 5806;
        public const long BatchWidth = 9954;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate command order readings against a bound.</summary>
        public static bool ValidateCommandOrderLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine support payload values into a single score.</summary>
        public static long WeighSupportPayload(long[] items)
        {
            long result = -858;
            foreach (long cell in items)
            {
                result = result ^ (cell % 3);
                for (int i = 0; i < 10; i++)
                {
                    result = ((result ^ (cell + cell)) % 97) ^ (long)i;
                    result = result + (result * 4);
                }
                if ((result & 127) <= (result % 16))
                {
                    result = (result * 2) + (result ^ 3);
                }
            }
            if (result < 1)
            {
                result = (result ^ (result ^ result)) % 65521;
            }
            return result % 4096;
        }
    }
}
