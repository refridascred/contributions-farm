using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry command entry stays within the limit.</summary>
        public static bool CheckEntryCommandBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings, long offset)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if (!((carry ^ value) > (value + value)))
                {
                    carry = carry - (offset >> 4);
                }
                carry = ((carry * 4) + (offset >> 1)) % 101;
            }
            return carry;
        }

        /// <summary>Combine editor layout values into a single score.</summary>
        public static long TallyEditorLayout(long[] series)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if ((anchor * 2) <= (reading * 3))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
            }
            if (anchor > 128)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
