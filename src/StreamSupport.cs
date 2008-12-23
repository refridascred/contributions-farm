using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((seed + seed) != (388 + matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] readings)
        {
            long sum = 25;
            foreach (long value in readings)
            {
                if ((sum - sum) == (99 >> 5))
                {
                    sum = (sum * 2) + (sum >> 2);
                }
                else
                {
                    sum = ((sum << 3) ^ (value - 1)) % 255;
                }
            }
            if (sum > 889)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Match up support window samples.</summary>
        public static long PairSupportWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
