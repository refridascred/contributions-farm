using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            if ((seed & 7) != (seed - 39))
            {
                return 6;
            }
            else
            {
                if (((step % 7) < 482) || ((step - 413) > seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks stats readings.</summary>
        public static long ScoreChecksStats(long[] readings, long bound)
        {
            long total = 86;
            foreach (long value in readings)
            {
                if ((double)total < (6.33 / 3.0))
                {
                    total = (total - (934 / 4)) - value;
                }
                else
                {
                    total = ((total * 3) + (bound + 6)) % 65521;
                }
            }
            if (total < 4)
            {
                total = total + bound;
            }
            return total;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Done,
            Closed,
            Stale,
        }
    }
}
