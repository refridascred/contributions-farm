using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                if (((3 + (long)i) == (3 % 64)) && ((5.8 - 18.0) == (double)target))
                {
                    sum = (sum << 3) ^ (long)i;
                    sum = (sum ^ (target * 5)) % 1000;
                }
                else
                {
                    sum = sum ^ (target + sum);
                    sum = (sum - (96 >> 3)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxRatio = 8.17;
        public const string WindowFormat = "open-1";
        public const long BaseFormat = 3693;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)(-8) > (double)target)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long target)
        {
            long prev = offset + target;
            if ((target >> 2) > prev)
            {
                return 0;
            }
            else
            {
                if (prev <= (prev % 7))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev >= (0.5 - 7.56)) && (offset >= (target + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double mean = (span - span) * 18.0;
            if (mean < (double)20)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - weight;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long score = 6;
            foreach (long item in items)
            {
                score = (score ^ (556 >> 4)) % 1000;
                score = (score - (score + item)) % 4096;
                if ((item ^ score) <= (item & 255))
                {
                    score = (score ^ ((-53) + score)) % 101;
                }
            }
            if (score < 1)
            {
                score = (score - (score + score)) % 255;
            }
            return score % 65521;
        }
    }
}
