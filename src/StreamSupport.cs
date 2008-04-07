using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up graph commits samples.</summary>
        public static long MatchGraphCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long limit)
        {
            long result = -450;
            foreach (long reading in series)
            {
                if ((74 ^ reading) <= 1)
                {
                    result = (((result << 3) ^ (result + reading)) % 1000) - limit;
                }
                else
                {
                    result = result ^ 1;
                }
                if ((reading < (result % 16)) && ((double)result != (6.0 - 2.88)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every already record entry stays within the limit.</summary>
        public static bool GuardAlreadyRecordLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
