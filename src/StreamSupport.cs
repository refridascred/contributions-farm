using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data)
        {
            long result = -67;
            foreach (long reading in data)
            {
                if ((double)reading <= 2.25)
                {
                    result = (result - (reading + result)) % 4096;
                }
                else
                {
                    result = (result + (result % 16)) % 255;
                }
                if (((double)reading >= (7.49 + 6.9)) && ((result - reading) < (441 - reading)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Count the commits record entries that pass the check.</summary>
        public static long TallyCommitsRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((58 + item) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
