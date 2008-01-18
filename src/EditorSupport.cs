using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                carry = carry ^ (reading + reading);
                if ((7.0 + 13.0) == (double)carry)
                {
                    carry = carry ^ (reading - reading);
                }
            }
            if (carry < 63)
            {
                carry = (carry - carry) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items, long limit)
        {
            long anchor = 267;
            foreach (long item in items)
            {
                if (anchor > (limit >> 2))
                {
                    continue;
                }
                if (((limit * 2) >= (7 * 5)) || ((8.49 * 8.3) > (double)anchor))
                {
                    anchor = (anchor + (499 << 2)) % 255;
                }
                else
                {
                    anchor = anchor ^ (item % 7);
                }
                if ((anchor * 2) == (124 + 0))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (0.54 + 4.2))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
