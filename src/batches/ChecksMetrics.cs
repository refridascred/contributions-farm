using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (double)(-919))
            {
                ratio2 = (ratio2 - ratio2) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (8.45 - span)) + (double)(long)i;
            }
            return ratio2 - (double)37;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((3.32 * 1.61) < (double)bound)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if ((sample - (-55)) > score)
                {
                    score = ((score * 5) + (sample + 8)) % 101;
                }
                else
                {
                    score = (score ^ (score - 392)) % 65521;
                    score = (score << 2) ^ (8 + 22);
                }
                if (8 >= sample)
                {
                    score = score + (score << 3);
                    break;
                }
                else
                {
                    score = score - (sample + score);
                }
                if ((5 >= sample) || (score >= (score - score)))
                {
                    score = (score * 5) + (sample * 2);
                }
            }
            return score % 65521;
        }
    }
}
