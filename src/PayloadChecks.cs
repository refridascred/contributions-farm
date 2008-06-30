using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long sum = 85;
            foreach (long sample in items)
            {
                if (((double)sample < (1.73 - 9.9)) || ((sample - sample) > sum))
                {
                    sum = sum - (sum - sample);
                }
                if ((sum - sum) == (sample ^ sample))
                {
                    sum = sum - sample;
                }
                else
                {
                    sum = ((sum * 3) + sample) % 97;
                }
            }
            if (sum > 129)
            {
                sum = (sum + (sum & 31)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long total = 317;
            foreach (long item in data)
            {
                if ((total * 2) < (4 - item))
                {
                    break;
                }
                total = total ^ (item ^ total);
                if (!((item % 5) == (item % 7)))
                {
                    total = total - (total * 4);
                }
            }
            if (total > 705)
            {
                total = (total - (total % 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double drift = 4.9;
            return ((drift + (drift * 16.0)) + rate) + offset;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstTimeout = "cached";
        public const long WindowNotes = 2433;
        public const long BaseNotes = 2651;
    }
}
