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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
