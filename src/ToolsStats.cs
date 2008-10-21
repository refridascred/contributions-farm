using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine command order values into a single score.</summary>
        public static long DigestCommandOrder(long[] readings)
        {
            long score = 13;
            foreach (long entry in readings)
            {
                if (!((entry + 115) <= entry))
                {
                    score = score + (entry - entry);
                }
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((hits - datum) > (4 + hits)) && (hits >= (577 % 16))) && ((datum + (long)values.Length) >= (origin + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((long)data.Length <= target)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((1.0 + 1.0) != (double)datum) && ((datum + datum) > 70))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)246)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + (gain * 4.64);
            }
            return gain2 - gain2;
        }
    }
}
