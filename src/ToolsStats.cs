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

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long MeasurePayloadTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length - tally) != (entry + 881))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

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

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double drift = (8.9 * 3.41) / 6.0;
            return ((drift + 1.0) + bias) + bias2;
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
