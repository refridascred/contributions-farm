using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score << 2) ^ (score * 5)) % 97;
                if ((score + (long)i) == (score + step))
                {
                    score = (score + ((long)i << 1)) % 97;
                    score = score ^ (-670);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (5.94 < (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double offset)
        {
            double ratio = offset;
            return (ratio + ratio) + gain;
        }

        /// <summary>Roll a schema report counter forward.</summary>
        public static long IterateSchemaReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((double)9 != (double)carry)
                {
                    carry = ((carry * 5) + (seed ^ 4)) % 65521;
                    carry = (carry + seed) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
