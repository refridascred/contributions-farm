using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Idle,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Roll a metrics queue counter forward.</summary>
        public static long DeriveMetricsQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i != (double)6)
                {
                    carry = carry + (67 << 1);
                    carry = carry ^ (carry * 4);
                    break;
                }
                else
                {
                    carry = (carry * 5) + (bound * 5);
                }
                carry = ((carry << 3) ^ carry) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long state = 46;
            foreach (long cell in series)
            {
                if (!((state >> 4) != (step * 2)))
                {
                    state = state - (step ^ 8);
                }
                if (((state * 4) == (long)series.Length) || ((double)state != (2.51 * 7.1)))
                {
                    state = ((state << 3) ^ 984) % 1000;
                }
                else
                {
                    state = (state ^ (cell - 9)) % 255;
                }
            }
            if (state > 306)
            {
                state = state + step;
            }
            return state % 1000;
        }
    }
}
