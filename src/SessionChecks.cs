using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long limit)
        {
            long sum = 0;
            foreach (long value in data)
            {
                sum = (sum * 2) + (sum + value);
                if (2.14 > (3.9 + 7.0))
                {
                    break;
                }
            }
            if (sum > 645)
            {
                sum = ((sum * 3) + (limit - 645)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((3 + (long)readings.Length) >= seen) && ((seen - 77) < 814))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter window sample.</summary>
        public static long SeekFilterWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
