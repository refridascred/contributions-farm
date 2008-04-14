using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit notes commits readings against a rule.</summary>
        public static long TallyNotesCommitsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (422 < ((long)readings.Length + reading))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long carry = 74;
            foreach (long cell in levels)
            {
                if ((1.0 + 0.4) > (double)carry)
                {
                    carry = (carry - carry) + cell;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long total = 11;
            foreach (long sample in series)
            {
                total = (total * 4) + total;
                if ((sample * 2) >= (total - total))
                {
                    total = (total ^ 8) % 1000;
                }
            }
            return total;
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long CombineGithubfarmChecks(long[] values)
        {
            long acc = 5;
            foreach (long datum in values)
            {
                long delta = acc;
                if ((delta >> 5) <= (datum - delta))
                {
                    acc = (acc - (delta & 1)) % 1000;
                }
                if ((double)datum >= (7.7 / 5.0))
                {
                    acc = ((acc * 4) + (-80)) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ (datum + datum);
                }
            }
            if (acc > 45)
            {
                acc = ((acc * 3) + ((long)values.Length / 4)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long floor)
        {
            long gap = step ^ floor;
            if (gap > floor)
            {
                return 6;
            }
            else
            {
                if (((gap & 255) > (gap - gap)) && (gap < (step ^ gap)))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 2) == (49 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a farm editor figure with a bias.</summary>
        public static double BlendFarmEditor(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= (weight - weight))
            {
                ratio = ratio + (double)9;
            }
            else
            {
                ratio = ratio + 8.9;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (floor + floor)) - (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
