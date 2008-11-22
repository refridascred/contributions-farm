using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of layout schema entries.</summary>
        public static long WeighLayoutSchema(long[] data)
        {
            long anchor = 926;
            foreach (long value in data)
            {
                if (!((double)value < (3.0 + 7.7)))
                {
                    anchor = anchor + value;
                }
                if (value <= (anchor ^ anchor))
                {
                    anchor = (anchor ^ (anchor + value)) % 4096;
                }
                if ((value + value) < value)
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) % 101;
                }
            }
            if (anchor > 40)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)step <= (1.9 - 3.83))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }
    }
}
