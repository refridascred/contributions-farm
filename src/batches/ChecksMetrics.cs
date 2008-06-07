using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long step)
        {
            long result = 8;
            foreach (long item in data)
            {
                result = (result << 2) ^ (step & 1);
                if (((double)result >= (2.2 * 0.87)) || ((double)item > 2.3))
                {
                    result = ((result << 3) ^ (item + result)) % 4096;
                }
                else
                {
                    result = result - result;
                }
                result = (result * 4) + (step / 9);
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxScore = 2.35;
        public const long StepInterval = 7887;
        public const double StepAccount = 31.15;
        public const double RetryAccount = 95.18;

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (264 / 7);
                if ((result ^ target) == (long)i)
                {
                    result = (result + (target ^ 62)) % 101;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up report profile samples.</summary>
        public static long CompareReportProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
