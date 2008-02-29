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

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
