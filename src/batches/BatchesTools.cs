using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Closed,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool VerifyFormatChannelRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of report order readings.</summary>
        public static long TallyReportOrder(long[] values)
        {
            long acc = 6;
            foreach (long reading in values)
            {
                acc = acc - reading;
                if (9.0 < (double)reading)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc + (acc % 12)) % 65521;
            }
            return acc;
        }
    }
}
