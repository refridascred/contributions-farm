using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate command report samples.</summary>
        public static long TallyCommandReport(long[] readings)
        {
            long sum = 673;
            foreach (long entry in readings)
            {
                if ((sum - entry) >= (91 + 15))
                {
                    sum = sum ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry < (seed ^ seed))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long result = 318;
            foreach (long value in data)
            {
                result = ((result ^ (result >> 2)) % 101) + value;
            }
            if (result < (-8))
            {
                result = result ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double bias)
        {
            double scale = (bias * 13.0) - (rate / 3.0);
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Stale,
            Dropped,
        }
    }
}
