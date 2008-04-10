using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] samples, long bound)
        {
            long score = 538;
            foreach (long cell in samples)
            {
                if (((score << 3) > score) && ((2.0 - 6.3) < (double)bound))
                {
                    score = score - (score % 60);
                }
                if ((bound / 8) > cell)
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = (score - score) % 1000;
            }
            return score;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data, long bound)
        {
            long carry = 268;
            foreach (long item in data)
            {
                if (carry <= (item - carry))
                {
                    carry = (((carry * 3) + (item + carry)) % 4096) - bound;
                }
                else
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double rate = (double)(175 * 2);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (double)(long)i) - gain;
            }
            return rate - span;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - reading) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
