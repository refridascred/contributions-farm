using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 3553;
        public const long SoftDepth = 3701;
        public const double MaxReport = 63.83;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((13.0 * 3.59) >= (double)seed)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length - anchor) >= anchor)
                {
                    anchor = ((anchor * 2) + (cell & 63)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (cell + 4)) % 1000;
                }
                if (((cell - anchor) > (anchor * 5)) && ((target - 87) == (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 5) + 85;
            }
            return anchor;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (double)30) + bias;
        }
    }
}
