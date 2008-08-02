using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a contributi support counter forward.</summary>
        public static long RollContributiSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((offset * 5) == (sum / 3))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (-50)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if (result <= (result + result))
                {
                    result = ((result - (result & 63)) % 97) ^ value;
                }
            }
            if (result < (-47))
            {
                result = (result - (result + 944)) % 101;
            }
            return result;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 65;
            foreach (long reading in series)
            {
                result = (result ^ (889 + 230)) % 255;
                if (reading < (result << 3))
                {
                    result = ((result * 5) + reading) % 255;
                }
                if (reading >= (result % 8))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
