using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches - value) < floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix + (offset - offset);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double gain = (double)0 - (weight * 3.9);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (9.7 + weight)) + (double)(long)i) + floor;
            }
            return gain + (14.0 / 3.0);
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Synced,
            Idle,
            Locked,
        }
    }
}
