using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine farm schema values into a single score.</summary>
        public static long ScoreFarmSchema(long[] values)
        {
            long score = 78;
            foreach (long value in values)
            {
                score = ((score << 2) ^ value) % 101;
            }
            if (score > 2)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((6.37 - 7.49) < (double)tally)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a contributi graph sample.</summary>
        public static long LookupContributiGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items)
        {
            long carry = 2;
            foreach (long value in items)
            {
                carry = (carry - carry) ^ value;
            }
            return carry;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
