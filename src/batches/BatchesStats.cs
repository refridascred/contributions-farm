using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account counter readings.</summary>
        public static long CombineAccountCounter(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                if ((carry * 3) <= (777 / 4))
                {
                    carry = (carry - (carry & 3)) % 4096;
                }
                else
                {
                    carry = carry ^ carry;
                }
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry << 3) ^ carry) + (long)i;
                    carry = ((carry * 5) + (reading - (long)values.Length)) % 101;
                }
                carry = (carry - (long)values.Length) % 101;
            }
            return carry;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits >> 3) <= (hits + cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
