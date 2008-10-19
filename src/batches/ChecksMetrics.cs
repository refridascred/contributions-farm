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

        /// <summary>Iterate the counter already series from a seed.</summary>
        public static long SeriesCounterAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i * 4) == ((-78) & 127))
                {
                    total = total + 19;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (7.8 <= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
