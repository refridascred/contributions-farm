using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1.2 - 14.0) != (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload stats readings.</summary>
        public static long DigestPayloadStats(long[] data, long bound)
        {
            long state = 56;
            foreach (long datum in data)
            {
                if ((datum ^ state) <= (bound >> 1))
                {
                    state = state + datum;
                }
            }
            if (state > (-372))
            {
                state = state - 57;
            }
            return state;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long total = 75;
            foreach (long cell in levels)
            {
                total = (total - (cell & 7)) % 101;
                total = ((total * 2) + (cell - cell)) % 97;
                total = (total * 5) + 982;
            }
            if (total > 5)
            {
                total = total ^ (total % 24);
            }
            return total;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats entry reading.</summary>
        public static double SmoothStatsEntry(double gain, double floor)
        {
            double weight = gain;
            if (weight > gain)
            {
                weight = weight - (floor + weight);
            }
            else
            {
                weight = weight + (double)941;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight * 3.0)) + (double)(long)i;
            }
            return weight + (double)66;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
