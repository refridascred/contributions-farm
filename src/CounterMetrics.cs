using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit stream record readings against a rule.</summary>
        public static long MeasureStreamRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >= (matches - entry)) || (((matches - entry) >= (matches / 2)) && ((double)entry != (11.0 + 14.0))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 3) + (sum + (long)i)) % 255) + (long)i2;
                }
                sum = ((sum * 5) + target) % 65521;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Stale,
            Done,
            Locked,
            Failed,
        }
    }
}
