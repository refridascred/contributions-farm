using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double load = offset;
            if (load < (double)17)
            {
                load = load + (offset - 5.8);
            }
            else
            {
                load = load + load;
            }
            return load - weight;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Draft,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data)
        {
            long carry = 265;
            foreach (long item in data)
            {
                carry = (carry + (item / 7)) % 4096;
            }
            if (carry > 21)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Count the buffer order entries that pass the check.</summary>
        public static long TallyBufferOrderOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally >= origin)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
