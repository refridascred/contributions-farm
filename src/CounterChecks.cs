using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate support session readings against a bound.</summary>
        public static bool VerifySupportSessionBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Pending,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value >> 5) <= (value * 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= ratio)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (rate + offset);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 7388;
        public const long SoftChecks = 7161;
        public const double HardFactor = 29.49;
    }
}
