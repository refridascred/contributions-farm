using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double rate = (gain / 5.0) * 3.15;
            return (rate + (gain * 4.0)) + bias;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value & 31) < (value + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
