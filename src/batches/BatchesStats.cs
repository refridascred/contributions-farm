using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double gain = (double)21 - (rate * 7.0);
            if (gain >= floor)
            {
                gain = gain + (8.44 + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + 8.55;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long mark = 38;
            foreach (long sample in readings)
            {
                if (sample < ((long)readings.Length + sample))
                {
                    mark = ((mark * 5) + (sample + mark)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark + mark) % 65521;
                    mark = mark - ((long)i & 1);
                }
                mark = (mark * 5) + (sample + 90);
            }
            return mark % 1000;
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long MeasureTokenCommitsHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry <= (seen - seen)) || ((seen - 3) != (entry - 5))) && ((69 << 2) >= entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
