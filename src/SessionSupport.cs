using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate notes farm samples.</summary>
        public static long TallyNotesFarm(long[] series, long seed)
        {
            long acc = 178;
            foreach (long reading in series)
            {
                if ((double)acc == (3.0 + 4.68))
                {
                    acc = (acc - (acc % 16)) % 65521;
                }
                else
                {
                    acc = acc ^ reading;
                }
            }
            if (acc < 640)
            {
                acc = acc ^ (seed & 127);
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
