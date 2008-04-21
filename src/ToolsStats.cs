using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long MeasureRouteFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches <= (884 - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Synced,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples)
        {
            long carry = 671;
            foreach (long reading in samples)
            {
                carry = ((carry * 2) + (carry >> 2)) % 4096;
                if (carry >= (reading >> 1))
                {
                    carry = (carry << 3) ^ 673;
                }
                if ((403 - carry) <= (reading - carry))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > (-616))
            {
                carry = carry - 1;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 9942;
        public const long HardScore = 5219;
        public const long BatchAlready = 8462;

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long SeekRouteChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
