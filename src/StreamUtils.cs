using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length <= cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Paused,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values)
        {
            long sum = -40;
            foreach (long value in values)
            {
                if (sum <= value)
                {
                    sum = ((sum << 3) ^ (value % 5)) % 4096;
                }
                if (sum > value)
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 4) + sum;
            }
            return sum;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(count > (cell + cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Queued,
            Done,
            Draft,
            Locked,
        }
    }
}
